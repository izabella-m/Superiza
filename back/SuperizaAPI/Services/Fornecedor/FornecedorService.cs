using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Data;
using SuperizaAPI.Dto;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Fornecedor;

public class FornecedorService : IFornecedorInterface
{

    private readonly AppDbContext _context;

    public FornecedorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseModel<List<FornecedorModel>>> ListarFornecedores()
    {
        ResponseModel<List<FornecedorModel>> resposta = new ResponseModel<List<FornecedorModel>>();
        try
        {
            var fornecedores = await _context.Fornecedores.ToListAsync();

            resposta.Dados = fornecedores;
            resposta.Mensagem = "Todos os fornecedores foram encontrados";
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
        return resposta; 
    }

    public async Task<ResponseModel<List<FornecedorModel>>> CriarFornecedores(FornecedorCriacaoDto fornecedorCriacaoDto)
    {
        ResponseModel<List<FornecedorModel>> resposta = new ResponseModel<List<FornecedorModel>>();

        try
        {
            var fornecedores = new FornecedorModel()
            {
                Nome = fornecedorCriacaoDto.Nome,
                Contato = fornecedorCriacaoDto.Contato,
            };
            
            _context.Add(fornecedores);
            await _context.SaveChangesAsync();
            
            resposta.Dados = await _context.Fornecedores.ToListAsync();
            resposta.Mensagem = "Fornecedor criado com sucesso";
            
            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<ResponseModel<List<FornecedorModel>>> EditarFornecedores(FornecedorEdicaoDto fornecedorEdicaoDto)
    {
        ResponseModel<List<FornecedorModel>> resposta = new ResponseModel<List<FornecedorModel>>();

        try
        {
            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(fornecedorBanco => fornecedorBanco.Id == fornecedorEdicaoDto.Id);
            if (fornecedor == null)
            {
                resposta.Mensagem = "Nenhum fornecedor encontrado";
                return resposta;
            }
            
            fornecedor.Contato = fornecedorEdicaoDto.Contato;
            
            _context.Update(fornecedor);
            await _context.SaveChangesAsync();
            
            resposta.Dados = await _context.Fornecedores.ToListAsync();
            resposta.Mensagem = "Fornecedor editado com sucesso";
            
            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<ResponseModel<List<FornecedorModel>>> DeletarFornecedores(int idFornecedor)
    {
        ResponseModel<List<FornecedorModel>> resposta = new ResponseModel<List<FornecedorModel>>();

        try
        {
            var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(fornecedorBanco => fornecedorBanco.Id == idFornecedor);
            if (fornecedor == null)
            {
                resposta.Mensagem = "Nenhum fornecedor encontrado";
                return resposta;
            }
            
            _context.Remove(fornecedor);
            await _context.SaveChangesAsync();
            
            resposta.Dados = await _context.Fornecedores.ToListAsync();
            resposta.Mensagem = "Fornecedor deletado com sucesso";
            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }
    
}