using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AguaAraras {
    internal class Database {

        /// <summary>
        /// Adjusts and returns connection string according to computer
        /// </summary>
        private static SqlConnection GetConnectionAgua() {
            return GetConnection(ConfigurationManager.ConnectionStrings["AguaAraras"].ToString());
        }

        private static SqlConnection GetConnectionMoneyBin() {
            return GetConnection(ConfigurationManager.ConnectionStrings["MoneyBin"].ToString());
        }

        /// <summary>
        /// Returns an opened connection object to Access DB
        /// </summary>
        /// <returns>OleDbConnection conn</returns>
        private static SqlConnection GetConnection(string connectionString) {
            try {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.GetConnection()\nString: {connectionString}\n{ex.Message}.");
                return null;
            }
        }

        public static List<Pessoa> PessoasGet() {
            try {
                var pessoas = new List<Pessoa>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Pessoas", conn) {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        pessoas.Add(new Pessoa(r));
                    r.Close();
                    return pessoas;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.GetPessoas(): {ex.Message}.");
                return null;
            }
        }

        public static bool PessoaUpdate(Pessoa p,
            List<Endereco> endUpdate, List<Endereco> endDelete,
            List<Telefone> telUpdate, List<Telefone> telDelete) {
            try {
                using (var conn = GetConnectionAgua()) {
                    var transaction = conn.BeginTransaction("Transaction");
                    var cmd = new SqlCommand("sp_PessoaUpdate", conn) {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = transaction
                    };
                    try {
                        cmd.Parameters.Add(new SqlParameter("@ID", p.ID));
                        cmd.Parameters.Add(new SqlParameter("@Ativo", p.Ativo));
                        cmd.Parameters.Add(new SqlParameter("@Tratamento", p.Tratamento));
                        cmd.Parameters.Add(new SqlParameter("@Nome", p.Nome));
                        cmd.Parameters.Add(new SqlParameter("@Sobrenome", p.Sobrenome));
                        cmd.Parameters.Add(new SqlParameter("@EMail", p.EMail));
                        cmd.Parameters.Add(new SqlParameter("@Cobranca", p.Cobranca));
                        cmd.Parameters.Add(new SqlParameter("@Recibo", p.Recibo));
                        cmd.Parameters.Add(new SqlParameter("@Atualizar", p.Atualizar));
                        cmd.Parameters.Add(new SqlParameter("@Observacoes", p.Observacoes));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "sp_EnderecoUpsert";
                        foreach (Endereco end in endUpdate) {
                            end.PessoaID = p.ID;
                            cmd.Parameters.Add(new SqlParameter("@ID", end.ID));
                            cmd.Parameters.Add(new SqlParameter("@PessoaID", end.PessoaID));
                            cmd.Parameters.Add(new SqlParameter("@Logradouro", end.Logradouro));
                            cmd.Parameters.Add(new SqlParameter("@Bairro", end.Bairro));
                            cmd.Parameters.Add(new SqlParameter("@Cidade", end.Cidade));
                            cmd.Parameters.Add(new SqlParameter("@Estado", end.Estado));
                            cmd.Parameters.Add(new SqlParameter("@CEP", end.uCEP));
                            cmd.Parameters.Add(new SqlParameter("@Residencia", end.Residencia));
                            cmd.Parameters.Add(new SqlParameter("@Correspondencia", end.Correspondencia));
                            var pNewID = cmd.Parameters.Add("@NewId", SqlDbType.Int);
                            pNewID.Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            var idAsNullableInt = pNewID.Value as int?;
                            end.ID = idAsNullableInt ?? end.ID;
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "sp_EnderecoDelete";
                        foreach (var end in endDelete) {
                            cmd.Parameters.Add(new SqlParameter("@ID", end.ID));
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "sp_TelefoneUpsert";
                        foreach (var tel in telUpdate) {
                            tel.PessoaID = p.ID;
                            cmd.Parameters.Add(new SqlParameter("@ID", tel.ID));
                            cmd.Parameters.Add(new SqlParameter("@PessoaID", tel.PessoaID));
                            cmd.Parameters.Add(new SqlParameter("@DDD", tel.DDD));
                            cmd.Parameters.Add(new SqlParameter("@Numero", tel.Numero));
                            cmd.Parameters.Add(new SqlParameter("@Tipo", tel.Tipo));
                            var pNewID = cmd.Parameters.Add("@NewId", SqlDbType.Int);
                            pNewID.Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            var idAsNullableInt = pNewID.Value as int?;
                            tel.ID = idAsNullableInt ?? tel.ID;
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "sp_TelefoneDelete";
                        foreach (var tel in telDelete) {
                            cmd.Parameters.Add(new SqlParameter("@ID", tel.ID));
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex) {
                        MessageBox.Show($@"Commit Exception Type: {ex.GetType()}\n\n  Message: {ex.Message}", @"Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Attempt to roll back the transaction. 
                        try {
                            transaction.Rollback();
                            return false;
                        }
                        catch (Exception ex2) {
                            // This catch block will handle any errors that may have occurred 
                            // on the server that would cause the rollback to fail, such as 
                            // a closed connection.
                            MessageBox.Show($@"Rollback Exception Type: {ex2.GetType()}\n\n  Message: {ex2.Message}", @"Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.PessoaUpdate(): {ex.Message}", @"Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public static List<Endereco> EnderecosGet() {
            try {
                var Enderecos = new List<Endereco>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Enderecos", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        Enderecos.Add(new Endereco(r));
                    r.Close();
                    return Enderecos;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.EnderecosGet(): {ex.Message}.");
                return null;
            }
        }

        public static List<Telefone> TelefonesGet() {
            try {
                var Telefones = new List<Telefone>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Telefones", conn) {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        Telefones.Add(new Telefone(r));
                    r.Close();
                    return Telefones;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.TelefonesGet(): {ex.Message}.");
                return null;
            }
        }

        public static List<Recibo> RecibosGet() {
            try {
                var Recibos = new List<Recibo>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Recibos", conn) {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        Recibos.Add(new Recibo(r));
                    r.Close();
                    return Recibos;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.RecibosGet(): {ex.Message}.");
                return null;
            }
        }

        public static Recibo RecibosGetLast() {
            try {
                Recibo ultimoRecibo = null;
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_ReciboLast", conn) {CommandType = CommandType.StoredProcedure};
                    var r = cmd.ExecuteReader();
                    if (r.Read())
                        ultimoRecibo = new Recibo(r);
                    r.Close();
                    return ultimoRecibo;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ReciboGetLast(): {ex.Message}.");
                return null;
            }
        }

        public static bool ReciboUpdate(Recibo recibo, List<Cota> cotas) {
            try {
                using (var conn = GetConnectionAgua()) {
                    var transaction = conn.BeginTransaction("Transaction");
                    var cmd = new SqlCommand("sp_ReciboUpsert", conn) {
                        CommandType = System.Data.CommandType.StoredProcedure,
                        Transaction = transaction
                    };
                    try {
                        cmd.Parameters.Add(new SqlParameter("@ID", recibo.ID));
                        cmd.Parameters.Add(new SqlParameter("@Extra", recibo.Extra));
                        cmd.Parameters.Add(new SqlParameter("@Numero", recibo.Numero));
                        cmd.Parameters.Add(new SqlParameter("@Emissao", recibo.Emissao));
                        cmd.Parameters.Add(new SqlParameter("@Vencimento", recibo.Vencimento));
                        cmd.Parameters.Add(new SqlParameter("@Cota", recibo.Cota));
                        cmd.Parameters.Add(new SqlParameter("@Meses", recibo.Meses));
                        cmd.Parameters.Add(new SqlParameter("@Descricao", recibo.Descricao));
                        cmd.Parameters.Add(new SqlParameter("@Observacoes", recibo.Observacoes));
                        var pNewID = cmd.Parameters.Add("@NewId", SqlDbType.Int);
                        pNewID.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        var NewID = pNewID.Value as int?;
                        recibo.ID = NewID ?? recibo.ID;
                        cmd.Parameters.Clear();

                        if (NewID == null) {
                            cmd.CommandText = "sp_CotaUpdate";
                            foreach (var c in cotas) {
                                cmd.Parameters.Add(new SqlParameter("@ID", c.ID));
                                cmd.Parameters.Add(new SqlParameter("@Data", c.Data));
                                cmd.Parameters.Add(new SqlParameter("@Observacoes", c.Observacoes));
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex) {
                        MessageBox.Show($@"Commit Exception Type: {ex.GetType()}\n\n  Message: {ex.Message}", "Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Attempt to roll back the transaction. 
                        try {
                            transaction.Rollback();
                            return false;
                        }
                        catch (Exception ex2) {
                            // This catch block will handle any errors that may have occurred 
                            // on the server that would cause the rollback to fail, such as 
                            // a closed connection.
                            MessageBox.Show($@"Rollback Exception Type: {ex2.GetType()}\n\n  Message: {ex2.Message}", "Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ReciboUpsert(): {ex.Message}.", "Recibo Upsert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public static SortableBindingList<Cota> CotasGet(int ReciboID) {
            try {
                var cotas = new SortableBindingList<Cota>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Cotas", conn) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.Add(new SqlParameter("@ID", ReciboID));
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        cotas.Add(new Cota(r));
                    r.Close();
                    return cotas;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.CotasGet(): {ex.Message}.");
                return null;
            }
        }

        public static List<ReciboItem> ReciboItensGet(int ReciboID, bool GetOld = false) {
            try {
                var itens = new List<ReciboItem>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_ReciboItens", conn);
                    cmd.Parameters.Add(new SqlParameter("@ReciboID", ReciboID));
                    cmd.Parameters.Add(new SqlParameter("@GetOld", GetOld));
                    cmd.CommandType = CommandType.StoredProcedure;
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        itens.Add(new ReciboItem(r));
                    r.Close();
                    return itens;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ReciboItensGet(): {ex.Message}.");
                return null;
            }
        }

        public static SortableBindingList<Movimento> MovimentosGet() {
            try {
                var Movimentos = new SortableBindingList<Movimento>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Movimentos", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        Movimentos.Add(new Movimento(r));
                    r.Close();
                    return Movimentos;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.MovimentosGet(): {ex.Message}.");
                return null;
            }
        }


        public static bool MovimentosUpdate(List<Movimento> Movimentos, List<Movimento> Deleted) {
            try {
                using (var conn = GetConnectionAgua()) {
                    var transaction = conn.BeginTransaction("Transaction");
                    var cmd = new SqlCommand("sp_MovimentoUpsert", conn) {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = transaction
                    };
                    try {
                        foreach (var mov in Movimentos) {
                            cmd.Parameters.Add(new SqlParameter("@ID", mov.ID));
                            cmd.Parameters.Add(new SqlParameter("@Tipo", mov.Tipo));
                            cmd.Parameters.Add(new SqlParameter("@Data", mov.Data));
                            cmd.Parameters.Add(new SqlParameter("@Historico", mov.Historico));
                            cmd.Parameters.Add(new SqlParameter("@Valor", mov.Valor));
                            cmd.Parameters.Add(new SqlParameter("@Observacoes", mov.Observacoes));
                            var pNewID = cmd.Parameters.Add("@NewId", SqlDbType.Int);
                            pNewID.Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            var NewID = pNewID.Value as int?;
                            mov.ID = NewID ?? mov.ID;
                            cmd.Parameters.Clear();
                        }
                        cmd.CommandText = "sp_MovimentoDelete";
                        foreach (var mov in Deleted) {
                            cmd.Parameters.Add(new SqlParameter("@ID", mov.ID));
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex) {
                        MessageBox.Show($@"Commit Exception Type: {ex.GetType()}\n\n  Message: {ex.Message}", "Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Attempt to roll back the transaction. 
                        try {
                            transaction.Rollback();
                            return false;
                        }
                        catch (Exception ex2) {
                            // This catch block will handle any errors that may have occurred 
                            // on the server that would cause the rollback to fail, such as 
                            // a closed connection.
                            MessageBox.Show($@"Rollback Exception Type: {ex2.GetType()}\n\n  Message: {ex2.Message}", "Pessoa Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ReciboUpsert(): {ex.Message}.", "Recibo Upsert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public static bool ColetaPaga(int ReciboID) {
            try {
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_ColetaPaga", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ReciboID", ReciboID));
                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ColetaPaga(): {ex.Message}.");
                return false;
            }
        }

        public static void ColetaAdd(int ReciboID, DateTime Data) {
            try {
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_ColetaAdd", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ReciboID", ReciboID));
                    cmd.Parameters.Add(new SqlParameter("@Data", Data.Date));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ColetaAdd(): {ex.Message}.");
            }
        }

        public static SortableBindingList<Extrato> ExtratoGet() {
            try {
                var Extratos = new SortableBindingList<Extrato>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Extrato", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        Extratos.Add(new Extrato(r));
                    r.Close();
                    return Extratos;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.ExtratoGet(): {ex.Message}.");
                return null;
            }
        }

        public static SortableBindingList<Balanco> BalancoGet(string periodo) {
            try {
                var balanco = new SortableBindingList<Balanco>();
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Balanco", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@part", periodo));
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        balanco.Add(new Balanco(r));
                    r.Close();
                    return balanco;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.BalancoGet(): {ex.Message}.");
                return null;
            }
        }

        public static decimal VergilioGetLastPayment() {
            try {
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_VergilioUltimo", conn) {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    return (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.VergilioGetLastPayment(): {ex.Message}.");
                return 0m;
            }
        }

        public static List<BalanceItem> GetBalanceItems(int ID) {
            try {
                var items = new List<BalanceItem>();

                using (var conn = GetConnectionMoneyBin()) {
                    var cmd = new SqlCommand("sp_BalanceItemsAgua", conn) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                        items.Add(new BalanceItem(r));
                    r.Close();
                    return items;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in MoneyBin.GetBalanceItems(): {ex.Message}.");
                return null;
            }
        }

        public static int Tomadas() {
            try {
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_Tomadas", conn) {CommandType = CommandType.StoredProcedure};
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.Tomadas(): {ex.Message}.");
                return 0;
            }
        }

        internal static void VergilioAdd() {
            try {
                using (var conn = GetConnectionAgua()) {
                    var cmd = new SqlCommand("sp_VergilioAdd", conn) {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($@"Error in Database.VergilioAdd(): {ex.Message}.");
            }
        }
    }
}
