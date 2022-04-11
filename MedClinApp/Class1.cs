using System;

public class Pessoa
{
    public string Cargo { get; set; };
    public bool Status { get; set; };
    public string Endereco { get; set; };
    public int Numero { get; set; };
    public string Bairro { get; set; };
    public string Cidade { get; set; };
    public string Estado { get; set; };
    public string Status { get; set; };

    #region Construtores

    public Cargo(string cargo)
    {
        Cargo = cargo;
    }
    public Status(bool status)
    {
        Status = status;    
    }
    public Endereco()
    {

    }

    #endregion


}
