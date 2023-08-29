using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using motogoAPI.Entities;

namespace motogoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoGoApiController : ControllerBase
    {
        private readonly MyDbContext _context;
        public MotoGoApiController(MyDbContext context)
        {
            _context = context;
        }


        [HttpPost("NovoUsuario")]
        public IActionResult NovoUsuario( Usuarios novoUsuario){
            var conferenciaNome = _context.Usuario.SingleOrDefault(c => c.Nome.ToLower() == novoUsuario.Nome.ToLower());
            var conferenciaEmail = _context.Usuario.SingleOrDefault(c => c.Email.ToLower() == novoUsuario.Email.ToLower());
            if(conferenciaNome != null)
                return NotFound("Nome já cadastrado");
            if(conferenciaEmail != null )
                return NotFound("Email já cadastrado");
        
        /*string nome, string email, string senha, int telefone, int meioDePagamentoPadrao*/
        /*Usuarios novoUsuario = new Usuarios();
            novoUsuario.Nome = nome;
            novoUsuario.Email = email;
            novoUsuario.Senha = senha;
            novoUsuario.Telefone = telefone;
            novoUsuario.MeioDePagamentoPadrao = (EnumMeioDePagamentoPadrao)meioDePagamentoPadrao;*/

            _context.Usuario.Add(novoUsuario);
            _context.SaveChanges();
            return Ok(novoUsuario);
        }
        [HttpGet("TodosUsuarios")]
        public IActionResult ObterTodosUsuarios(){
        
           var todos = _context.Usuario;
            return Ok(todos);
        }

        [HttpGet("UsuarioPorId")]
        public IActionResult buscarUsuarioId(int id){
            var usuario = _context.Usuario.SingleOrDefault(U => U.IdUsuario == id);

            if(usuario == null)
                return NotFound("Usuario não encontrado");
            return Ok(usuario);
        }
        [HttpGet("UsuarioPorNome")]
        public IActionResult BuscarUsuarioPorNome(string nome){
            var busca = _context.Usuario.Where(B => B.Nome.ToLower().Contains(nome.ToLower()));
            if(busca == null)
                return NotFound("Usuário não encontrado");
            return Ok(busca);
        }
        [HttpGet("BuscarTodosEnderecosUsuarios")]
        public IActionResult TodosEnderecosUsuarios(){
            var enderecos = _context.EnderecoUsuario;
            return Ok(enderecos);
        }

        [HttpGet("BuscarEnderecoUsuarioPorId")]
        public IActionResult CadastrarEnderecoUsuario(int id){
            var usuario = _context.Usuario.SingleOrDefault(U => U.IdUsuario == id);

            if(usuario == null)
                return NotFound("Usuario não encontrado");
            var endereco = _context.EnderecoUsuario.Where(E => E.UsuarioId == id);
            if(endereco == null)
                return NotFound("Endereço não encontrado ou não cadastrado");
            return Ok(endereco);
            
        }
        
        [HttpPost("CadastrarEnderecoUsuario")]
        public IActionResult CadastrarEnderecoUsuario(int idUsuario, string logradouro, int numero, string bairro, string cep, string cidade, string uf){
           
           var usuario = _context.Usuario.SingleOrDefault(U => U.IdUsuario == idUsuario);
            if(usuario == null)
                return NotFound("Usuario não Encontrado");
            EnderecoUsuarios novoEndereco = new EnderecoUsuarios();
            novoEndereco.UsuarioId = idUsuario;
            novoEndereco.Logradouro = logradouro;
            novoEndereco.Numero = numero;
            novoEndereco.Bairro = bairro;
            novoEndereco.Cidade = cidade;
            novoEndereco.Cep = cep;
            novoEndereco.Uf = uf;

            _context.EnderecoUsuario.Add(novoEndereco);
            _context.SaveChanges();
            return Ok(novoEndereco);
        }
        
        [HttpPost("NovoEntregador")]
        public IActionResult NovoEntregador(Entregadores novoEntregador){
            var conferenciaNome = _context.Entregador.SingleOrDefault(c => c.Nome.ToLower() == novoEntregador.Nome.ToLower());
            var conferenciaCpf = _context.Entregador.SingleOrDefault(c => c.Cpf == novoEntregador.Cpf);
            var conferenciaEmail = _context.Entregador.SingleOrDefault(c => c.Email.ToLower() == novoEntregador.Email.ToLower());
            var conferenciaTelefone = _context.Entregador.SingleOrDefault(c => c.Telefone == novoEntregador.Telefone);
            var conferenciaLinkImagemEntregador = _context.Entregador.SingleOrDefault(c => c.ImagemCnhEntregador.ToLower() == novoEntregador.ImagemCnhEntregador.ToLower());
            var conferenciaLinkCnh = _context.Entregador.SingleOrDefault(c => c.ImagemCnhEntregador.ToLower() == novoEntregador.ImagemEntregador.ToLower());
            if(conferenciaNome != null)
                return NotFound("Nome já cadastrados");
            if(conferenciaCpf != null )
                return NotFound("Cpf já cadastrados");
            if(conferenciaEmail != null )
                return NotFound("Email já cadastrados");
            if(conferenciaTelefone != null )
                return NotFound("Telefone já cadastrados");
            if(conferenciaLinkImagemEntregador != null )
                return NotFound("Link da imagem do entregador já cadastrados");
            if(conferenciaLinkCnh != null )
                return NotFound("Link da imagem da CNH já cadastrados");

            _context.Entregador.Add(novoEntregador);
            _context.SaveChanges();
            return Ok(novoEntregador);
        }
         [HttpGet("TodosEntregadores")]
        public IActionResult TodosEntregadores(){
            var todos = _context.Entregador;
            if(todos == null )
                return NotFound("Vazio");
            
            else
                return Ok(todos);  
        }
        [HttpGet("EntregadorPorId")]
        public IActionResult buscarEntregadorId(int id){
            var entregador = _context.Entregador.SingleOrDefault(U => U.IdEntregador == id);

            if(entregador == null)
                return NotFound("Entregador não encontrado");
            return Ok(entregador);
        }
        [HttpGet("EntregadorPorNome")]
        public IActionResult BuscarEntregadorPorNome(string nome){
            var busca = _context.Entregador.Where(B => B.Nome.ToLower().Contains(nome.ToLower()));
            if(busca == null)
                return NotFound("Entregador não encontrado");
            return Ok(busca);
        }
       
        
        [HttpPost("CadastrarEnderecoEntregador")]
        public IActionResult CadastrarEnderecoEntregador(int idEntregador, string logradouro, int numero, string bairro, string cep, string cidade, string uf){
            var entregador = _context.Entregador.SingleOrDefault(U => U.IdEntregador == idEntregador);
            if(entregador == null)
                return NotFound("Entregador não Encontrado");
            EnderecoEntregadores novoEndereco = new EnderecoEntregadores();
            novoEndereco.EntregadorId = idEntregador;
            novoEndereco.Logradouro = logradouro;
            novoEndereco.Numero = numero;
            novoEndereco.Bairro = bairro;
            novoEndereco.Cidade = cidade;
            novoEndereco.Cep = cep;
            novoEndereco.Uf = uf;

            _context.EnderecoEntregador.Add(novoEndereco);
            _context.SaveChanges();
            return Ok(novoEndereco);
        }
        [HttpGet("BuscarEnderecoEntregadorPorId")]
        public IActionResult CadastrarEnderecoEntregador(int id){
            var entregador = _context.Entregador.Find(id);

            if(entregador == null)
                return NotFound("Entregador não encontrado");
            var endereco = _context.EnderecoEntregador.Where(E => E.EntregadorId == id);
            if(endereco == null)
                return NotFound("Endereço não encontrado ou não cadastrado");
            return Ok(endereco);
            
        }
        
        [HttpPost("CadastrarEnderecoRetirada")]
        public IActionResult CadastrarEnderecoRetirada(int idRetirada, string logradouro, int numero, string bairro, string cep, string cidade, string uf){
            EnderecosRetiradas novoEndereco = new EnderecosRetiradas();
            novoEndereco.IdEnderecoRetirada = idRetirada;
            novoEndereco.Logradouro = logradouro;
            novoEndereco.Numero = numero;
            novoEndereco.Bairro = bairro;
            novoEndereco.Cidade = cidade;
            novoEndereco.Cep = cep;
            novoEndereco.Uf = uf;

            _context.EnderecoRetirada.Add(novoEndereco);
            _context.SaveChanges();
            return Ok(novoEndereco);
        }
        [HttpGet("BuscarEnderecoRetiradaPorId")]
        public IActionResult BuscarEnderecoRetiradaPorId(int id){
            var retirada = _context.EnderecoRetirada.SingleOrDefault(U => U.IdEnderecoRetirada == id);

            if(retirada == null)
                return NotFound("Id não encontrado");
            return Ok(retirada);
        }

        [HttpPost("CadastrarEnderecoEntrega")]
        public IActionResult CadastrarEnderecoEntrega(int idEntrega, string logradouro, int numero, string bairro, string cep, string cidade, string uf){
            
            EnderecosEntregas novoEndereco = new EnderecosEntregas();
            novoEndereco.IdEnderecoEntrega = idEntrega;
            novoEndereco.Logradouro = logradouro;
            novoEndereco.Numero = numero;
            novoEndereco.Bairro = bairro;
            novoEndereco.Cidade = cidade;
            novoEndereco.Cep = cep;
            novoEndereco.Uf = uf;

            _context.EnderecoEntrega.Add(novoEndereco);
            _context.SaveChanges();
            return Ok(novoEndereco);
        }
        [HttpGet("BuscarEnderecoEntregaPorId")]
        public IActionResult BuscarEnderecoEntregaPorId(int id){
            var entrega = _context.EnderecoEntrega.Where(U => U.IdEnderecoEntrega == id);

            if(entrega == null)
                return NotFound("Id não encontrado");
            return Ok(entrega);
        }


        [HttpPost("NovoFuncionario")]
        public IActionResult NovoFuncionario(Funcionarios novoFuncionario){
            var conferenciaNome = _context.Funcionario.SingleOrDefault(c => c.Nome.ToLower() == novoFuncionario.Nome.ToLower());
            var conferenciaEmail = _context.Funcionario.SingleOrDefault(c => c.Email.ToLower() == novoFuncionario.Email.ToLower());
            var conferenciaImagemFuncionario = _context.Funcionario.SingleOrDefault(c => c.ImagemFuncionario.ToLower() == novoFuncionario.ImagemFuncionario.ToLower());
            var conferenciaImagemDocumentoFuncionario = _context.Funcionario.SingleOrDefault(c => c.ImagemDocumentoFuncionario.ToLower() == novoFuncionario.ImagemDocumentoFuncionario.ToLower());
            if(conferenciaNome != null )
                return NotFound("Nome já cadastrados");
            if(conferenciaEmail != null )
                return NotFound("Email já cadastrados");
            if(conferenciaImagemFuncionario != null )
                return NotFound("Link de imagem do funcionario já cadastrados");
            if(conferenciaImagemDocumentoFuncionario != null )
                return NotFound("Link de imagem do documento já cadastrados");

            _context.Funcionario.Add(novoFuncionario);
            _context.SaveChanges();

            return Ok(novoFuncionario);
        }
        [HttpGet("BuscarTodosFuncionarios")]
        public IActionResult ObterTodosFuncionarios(){
        
           var todos = _context.Funcionario;
            return Ok(todos);
        }

        [HttpGet("FuncionarioPorId")]
        public IActionResult buscarFuncionarioId(int id){
            var funcionario = _context.Funcionario.SingleOrDefault(U => U.IdFuncionario == id);

            if(funcionario == null)
                return NotFound("Funcionario não encontrado");
            return Ok(funcionario);
        }
        [HttpGet("FuncionarioPorNome")]
        public IActionResult BuscarFuncionarioPorNome(string nome){
            var busca = _context.Funcionario.Where(B => B.Nome.ToLower().Contains(nome.ToLower()));
            if(busca == null)
                return NotFound("Funcionário não encontrado");
            return Ok(busca);
        }
        
        [HttpPost("CadastrarEnderecoFuncionarios")]
        public IActionResult CadastrarEnderecoFuncionario(int idFuncionario, string logradouro, int numero, string bairro, string cep, string cidade, string uf){
            var funcionario = _context.Funcionario.SingleOrDefault(U => U.IdFuncionario == idFuncionario);
            if(funcionario == null)
                return NotFound("Funcionário não Encontrado");
            EnderecoFuncionarios novoEndereco = new EnderecoFuncionarios();
            novoEndereco.FuncionarioId = idFuncionario;
            novoEndereco.Logradouro = logradouro;
            novoEndereco.Numero = numero;
            novoEndereco.Bairro = bairro;
            novoEndereco.Cidade = cidade;
            novoEndereco.Cep = cep;
            novoEndereco.Uf = uf;

            _context.EnderecoFuncionario.Add(novoEndereco);
            _context.SaveChanges();
            return Ok(novoEndereco);
        }
        [HttpGet("BuscarEnderecoFuncionarioPorId")]
        public IActionResult CadastrarEnderecoFuncionario(int id){
            var funcionario = _context.Funcionario.Find(id);

            if(funcionario == null)
                return NotFound("Funcionario não encontrado");
            var endereco = _context.EnderecoUsuario.Where(E => E.UsuarioId == id);
            if(endereco == null)
                return NotFound("Endereço não encontrado ou não cadastrado");
            return Ok(endereco);
            
        }

        [HttpPost("NovaRemessa")]
        public IActionResult CadastraNovaRemessa(string nome, string descricao, double peso, double altura, double comprimento, double largura, double valor, string imagemRemessa){
            Remessa novaRemessa = new Remessa();
            novaRemessa.Nome = nome;
            novaRemessa.Descricao = descricao;
            novaRemessa.Peso = peso;
            novaRemessa.Altura = altura;
            novaRemessa.Comprimento = comprimento;
            novaRemessa.Largura = largura;
            novaRemessa.Valor = valor;
            novaRemessa.ImagemProduto = imagemRemessa;
            
            _context.Remessa.Add(novaRemessa);
            _context.SaveChanges();
            return Ok(novaRemessa);
        }
        [HttpGet("BuscarTodasRemessas")]
        public IActionResult ObterTodasRemessas(){
        
           var todos = _context.Remessa;
            return Ok(todos);
        }
        [HttpGet("RemessaPorId")]
        public IActionResult buscarRemessaPorId(int id){
            var remessa = _context.Remessa.SingleOrDefault(U => U.IdRemessa == id);

            if(remessa == null)
                return NotFound("Pedido não encontrado");
            return Ok(remessa);
        }

        [HttpPost("NovoPedido")]
        public IActionResult CadastraNovoPedido(int idUsuario, int idremessa, int idEnderecoRetirada, int idEnderecoEntrega, bool noite, bool chuva, double distanciaPrevista, double tempoEstimado){
            var usuario = _context.Usuario.SingleOrDefault(U => U.IdUsuario == idUsuario);
            if(usuario == null)
                return NotFound("Usuario não encontrado");
            var retirada = _context.EnderecoRetirada.SingleOrDefault(R => R.IdEnderecoRetirada == idEnderecoRetirada);
            if(retirada == null)
                return NotFound("Endereço de retirada não encontrado");
            var entrega = _context.EnderecoEntrega.SingleOrDefault(E => E.IdEnderecoEntrega == idEnderecoEntrega);
            if(entrega == null)
                return NotFound("Endereço de entrega não encontrado");           
            var precosTB = _context.Preco.Find(1);
            var valorKm = precosTB.PrecoKm;
            if(noite)
                valorKm *= precosTB.PrecoNoite;
            if(chuva)
                valorKm *= precosTB.PrecoChuva;
            double precokg = 1;
            var peso = _context.Remessa.SingleOrDefault(P => P.IdRemessa == idremessa);
            if(peso == null)
                return NotFound("Remesa não encontrada");

            if(peso.Peso <= 1 )
                precokg = precosTB.Preco1Kg;
            else if(peso.Peso <= 3)
                precokg *= precosTB.Preco3Kg;
            else if(peso.Peso <= 8)
                precokg *= precosTB.Preco8Kg;
            else if(peso.Peso <= 12)
                precokg *= precosTB.Preco12Kg;
            

            var valorprevisto = valorKm * distanciaPrevista + precosTB.PrecoTempo * tempoEstimado + precokg;

            Pedidos novoPedido = new Pedidos();
            novoPedido.UsuarioId = idUsuario;
            novoPedido.EnderecoRetiradaId = idEnderecoRetirada;
            novoPedido.EnderecoEntregasId = idEnderecoEntrega;
            novoPedido.StatusPedido = 0;
            novoPedido.DataHoraPedido = DateTime.Now;
            novoPedido.Noite = noite;
            novoPedido.Chovendo = chuva;
            novoPedido.ValorPorKm = valorKm;
            novoPedido.valorPrevisto = valorprevisto;
            novoPedido.DistanciaPrevista = distanciaPrevista;
            novoPedido.Distanciapercorrida = 0;
            novoPedido.ValorTotal = 0;
            novoPedido.StatusPagamento = false;
            novoPedido.RemessaId = idremessa;
            

            _context.Pedido.Add(novoPedido);
            _context.SaveChanges();
            return Ok(novoPedido);
        }
        [HttpGet("BuscarTodosPedidos")]
        public IActionResult ObterTodosPedidos(){
        
           var todos = _context.Pedido;
            return Ok(todos);
        }
        [HttpGet("PedidosPorId")]
        public IActionResult buscarPedidoPorId(int id){
            var pedido = _context.Pedido.SingleOrDefault(U => U.IdPedido == id);

            if(pedido == null)
                return NotFound("Pedido não encontrado");
            return Ok(pedido);
        }
        [HttpPatch("AlterarDistanciaPercorrida")]
        public IActionResult AlterarDistanciaPercorrida(int idpedido,double distanciaPercorrida, double tempoPercorrido){
            var pedido = _context.Pedido.SingleOrDefault(P => P.IdPedido == idpedido);
            if(pedido == null)
                return NotFound("Pedido não encontrado");
            pedido.Distanciapercorrida = distanciaPercorrida;
            var valorTotal = pedido.ValorPorKm * distanciaPercorrida * tempoPercorrido;
            pedido.ValorTotal = valorTotal;

            _context.Update(pedido);
            _context.SaveChanges();
            return Ok(pedido );
        }
        [HttpPatch("InserirEntregadorNoPedido")]
        public IActionResult InserirEntregadorNoPedido(int idPedido, int idEntregador){
            var pedido = _context.Pedido.SingleOrDefault(P => P.IdPedido == idPedido);
            var entregador = _context.Entregador.SingleOrDefault(E => E.IdEntregador == idEntregador);
            if(pedido == null)
                return NotFound("Pedido não encontrado");
            if(entregador == null)
            return NotFound("Entregador não encontrado");

            pedido.EntregadoresId = idEntregador;

            _context.Update(pedido);
            _context.SaveChanges();

            return Ok(pedido);
        }
        [HttpGet("VerificarPrecos")]
        public IActionResult VereficarPrecos(){
            var precos = _context.Preco;
            return Ok(precos);
        }
        [HttpPatch("AlterarPrecos")]
        public IActionResult AlterarPrecos(string NomeCampo, double novoPreco){
            var alter = _context.Preco.Find(1);
            
            if(NomeCampo.ToLower() == "precokm")
                alter.PrecoKm = novoPreco;
            if(NomeCampo.ToLower() == "preco1kg")
                alter.Preco1Kg = novoPreco;
            if(NomeCampo.ToLower() == "preco3kg")
                alter.Preco3Kg = novoPreco;
            if(NomeCampo.ToLower() == "preco8kg")
                alter.Preco8Kg = novoPreco;
            if(NomeCampo.ToLower() == "preco12kg")
                alter.Preco12Kg = novoPreco;
            if(NomeCampo.ToLower() == "precotempo")
                alter.PrecoTempo = novoPreco;
            if(NomeCampo.ToLower() == "precodia")
                alter.PrecoDia = novoPreco;
            if(NomeCampo.ToLower() == "preconoite")
                alter.PrecoNoite = novoPreco;
            if(NomeCampo.ToLower() == "precochuva")
                alter.PrecoChuva = novoPreco;
            if(NomeCampo.ToLower() == "porcentagementregador")
                alter.PorcentagemEntregador = novoPreco;

            _context.Preco.Update(alter);
            _context.SaveChanges();
            return Ok(alter);
        }

        
    }
}