/*
 * Criado por SharpDevelop.
 * Usu�rio: Adriano
 * Data: 1/12/2011
 * Hora: 18:35
 * 
 * Para alterar este modelo use Ferramentas | Op��es | Codifica��o | Editar Cabe�alhos Padr�o.
 */

using System;

namespace BaseLib.Network
{
	/// <summary>
	/// Description of IUser.
	/// </summary>
	public interface IUser
    {
        IClient Client { get; set; }
    }
}
