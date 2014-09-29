///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Kecamatan'
// Generated by LLBLGen v1.21.2003.712 Final on: 19 September 2006, 9:55:03
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace BkNet.DataAccess
{
	/// <summary>
	/// Purpose: Data Access class for the table 'Kecamatan'.
	/// </summary>
	public class Kecamatan : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		_published;
			private SqlDateTime		_createdDate, _modifiedDate;
			private SqlInt32		_ordering, _createdBy, _modifiedBy, _kabupatenKotaId, _kabupatenKotaIdOld, _id;
			private SqlString		_kode, _keterangan, _nama;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public Kecamatan()
		{
			// Nothing for now.
		}

		/// <summary>
		/// Purpose: IsExist method. This method will check Exsisting data from database.
		/// Addes By Ekitea On 19 September 2006
		/// </summary>
		/// <returns></returns>
		public bool IsExist()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_IsExist]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id));
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@Kode", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _kode));
				cmdToExecute.Parameters.Add(new SqlParameter("@Nama", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nama));
				cmdToExecute.Parameters.Add(new SqlParameter("@IsExist", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				int IsExist = int.Parse(cmdToExecute.Parameters["@IsExist"].Value.ToString());
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_IsExist' reported the ErrorCode: " + _errorCode);
				}

				return IsExist==1;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::IsExist::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Id</LI>
		///		 <LI>KabupatenKotaId</LI>
		///		 <LI>Kode</LI>
		///		 <LI>Nama</LI>
		///		 <LI>Keterangan. May be SqlString.Null</LI>
		///		 <LI>Published</LI>
		///		 <LI>Ordering</LI>
		///		 <LI>CreatedBy</LI>
		///		 <LI>CreatedDate</LI>
		///		 <LI>ModifiedBy. May be SqlInt32.Null</LI>
		///		 <LI>ModifiedDate. May be SqlDateTime.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@Kode", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _kode));
				cmdToExecute.Parameters.Add(new SqlParameter("@Nama", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nama));
				cmdToExecute.Parameters.Add(new SqlParameter("@Keterangan", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _keterangan));
				cmdToExecute.Parameters.Add(new SqlParameter("@Published", SqlDbType.Bit, 1, ParameterDirection.Input, false, 1, 0, "", DataRowVersion.Proposed, _published));
				cmdToExecute.Parameters.Add(new SqlParameter("@Ordering", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _ordering));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _createdBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 23, 3, "", DataRowVersion.Proposed, _createdDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _modifiedBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 23, 3, "", DataRowVersion.Proposed, _modifiedDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _id));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_id = (SqlInt32)cmdToExecute.Parameters["@Id"].Value;
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_Insert' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Id</LI>
		///		 <LI>KabupatenKotaId</LI>
		///		 <LI>Kode</LI>
		///		 <LI>Nama</LI>
		///		 <LI>Keterangan. May be SqlString.Null</LI>
		///		 <LI>Published</LI>
		///		 <LI>Ordering</LI>
		///		 <LI>CreatedBy</LI>
		///		 <LI>CreatedDate</LI>
		///		 <LI>ModifiedBy. May be SqlInt32.Null</LI>
		///		 <LI>ModifiedDate. May be SqlDateTime.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id));
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@Kode", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _kode));
				cmdToExecute.Parameters.Add(new SqlParameter("@Nama", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nama));
				cmdToExecute.Parameters.Add(new SqlParameter("@Keterangan", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _keterangan));
				cmdToExecute.Parameters.Add(new SqlParameter("@Published", SqlDbType.Bit, 1, ParameterDirection.Input, false, 1, 0, "", DataRowVersion.Proposed, _published));
				cmdToExecute.Parameters.Add(new SqlParameter("@Ordering", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _ordering));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _createdBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 23, 3, "", DataRowVersion.Proposed, _createdDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _modifiedBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 23, 3, "", DataRowVersion.Proposed, _modifiedDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_Update' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'KabupatenKotaId.
		/// This method will Update one or more existing rows in the database. It will reset the field 'KabupatenKotaId' in
		/// all rows which have as value for this field the value as set in property 'KabupatenKotaIdOld' to 
		/// the value as set in property 'KabupatenKotaId'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>KabupatenKotaId</LI>
		///		 <LI>KabupatenKotaIdOld</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWKabupatenKotaIdLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_UpdateAllWKabupatenKotaIdLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaIdOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaIdOld));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_UpdateAllWKabupatenKotaIdLogic' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::UpdateAllWKabupatenKotaIdLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_Delete' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method for a foreign key. This method will Delete one or more rows from the database, based on the Foreign Key 'KabupatenKotaId'
		/// </summary>
		/// <returns>True if succeeded, false otherwise. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>KabupatenKotaId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteAllWKabupatenKotaIdLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_DeleteAllWKabupatenKotaIdLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_DeleteAllWKabupatenKotaIdLogic' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::DeleteAllWKabupatenKotaIdLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>Id</LI>
		///		 <LI>KabupatenKotaId</LI>
		///		 <LI>Kode</LI>
		///		 <LI>Nama</LI>
		///		 <LI>Keterangan</LI>
		///		 <LI>Published</LI>
		///		 <LI>Ordering</LI>
		///		 <LI>CreatedBy</LI>
		///		 <LI>CreatedDate</LI>
		///		 <LI>ModifiedBy</LI>
		///		 <LI>ModifiedDate</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("Kecamatan");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_SelectOne' reported the ErrorCode: " + _errorCode);
				}

				if(toReturn.Rows.Count > 0)
				{
					_id = (Int32)toReturn.Rows[0]["Id"];
					_kabupatenKotaId = (Int32)toReturn.Rows[0]["KabupatenKotaId"];
					_kode = (string)toReturn.Rows[0]["Kode"];
					_nama = (string)toReturn.Rows[0]["Nama"];
					_keterangan = toReturn.Rows[0]["Keterangan"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["Keterangan"];
					_published = (bool)toReturn.Rows[0]["Published"];
					_ordering = (Int32)toReturn.Rows[0]["Ordering"];
					_createdBy = (Int32)toReturn.Rows[0]["CreatedBy"];
					_createdDate = (DateTime)toReturn.Rows[0]["CreatedDate"];
					_modifiedBy = toReturn.Rows[0]["ModifiedBy"] == System.DBNull.Value ? SqlInt32.Null : (Int32)toReturn.Rows[0]["ModifiedBy"];
					_modifiedDate = toReturn.Rows[0]["ModifiedDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)toReturn.Rows[0]["ModifiedDate"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("Kecamatan");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_SelectAll' reported the ErrorCode: " + _errorCode);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'KabupatenKotaId'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>KabupatenKotaId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWKabupatenKotaIdLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_SelectAllWKabupatenKotaIdLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("Kecamatan");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_SelectAllWKabupatenKotaIdLogic' reported the ErrorCode: " + _errorCode);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::SelectAllWKabupatenKotaIdLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: GetListWKabupatenKotaIdLogic method. This method will Select all rows from the table where is active.
		/// Added by Ekitea On 19 September 2006
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>KabupatenKotaId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable GetListWKabupatenKotaIdLogic()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[Kecamatan_GetListWKabupatenKotaIdLogic]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("Kecamatan");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@KabupatenKotaId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _kabupatenKotaId));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'Kecamatan_GetListWKabupatenKotaIdLogic' reported the ErrorCode: " + _errorCode);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Kecamatan::GetListWKabupatenKotaIdLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 Id
		{
			get
			{
				return _id;
			}
			set
			{
				SqlInt32 idTmp = (SqlInt32)value;
				if(idTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("Id", "Id can't be NULL");
				}
				_id = value;
			}
		}


		public SqlInt32 KabupatenKotaId
		{
			get
			{
				return _kabupatenKotaId;
			}
			set
			{
				SqlInt32 kabupatenKotaIdTmp = (SqlInt32)value;
				if(kabupatenKotaIdTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("KabupatenKotaId", "KabupatenKotaId can't be NULL");
				}
				_kabupatenKotaId = value;
			}
		}
		public SqlInt32 KabupatenKotaIdOld
		{
			get
			{
				return _kabupatenKotaIdOld;
			}
			set
			{
				SqlInt32 kabupatenKotaIdOldTmp = (SqlInt32)value;
				if(kabupatenKotaIdOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("KabupatenKotaIdOld", "KabupatenKotaIdOld can't be NULL");
				}
				_kabupatenKotaIdOld = value;
			}
		}


		public SqlString Kode
		{
			get
			{
				return _kode;
			}
			set
			{
				SqlString kodeTmp = (SqlString)value;
				if(kodeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("Kode", "Kode can't be NULL");
				}
				_kode = value;
			}
		}


		public SqlString Nama
		{
			get
			{
				return _nama;
			}
			set
			{
				SqlString namaTmp = (SqlString)value;
				if(namaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("Nama", "Nama can't be NULL");
				}
				_nama = value;
			}
		}


		public SqlString Keterangan
		{
			get
			{
				return _keterangan;
			}
			set
			{
				_keterangan = value;
			}
		}


		public SqlBoolean Published
		{
			get
			{
				return _published;
			}
			set
			{
				SqlBoolean publishedTmp = (SqlBoolean)value;
				if(publishedTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("Published", "Published can't be NULL");
				}
				_published = value;
			}
		}


		public SqlInt32 Ordering
		{
			get
			{
				return _ordering;
			}
			set
			{
				SqlInt32 orderingTmp = (SqlInt32)value;
				if(orderingTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("Ordering", "Ordering can't be NULL");
				}
				_ordering = value;
			}
		}


		public SqlInt32 CreatedBy
		{
			get
			{
				return _createdBy;
			}
			set
			{
				SqlInt32 createdByTmp = (SqlInt32)value;
				if(createdByTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("CreatedBy", "CreatedBy can't be NULL");
				}
				_createdBy = value;
			}
		}


		public SqlDateTime CreatedDate
		{
			get
			{
				return _createdDate;
			}
			set
			{
				SqlDateTime createdDateTmp = (SqlDateTime)value;
				if(createdDateTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("CreatedDate", "CreatedDate can't be NULL");
				}
				_createdDate = value;
			}
		}


		public SqlInt32 ModifiedBy
		{
			get
			{
				return _modifiedBy;
			}
			set
			{
				_modifiedBy = value;
			}
		}


		public SqlDateTime ModifiedDate
		{
			get
			{
				return _modifiedDate;
			}
			set
			{
				_modifiedDate = value;
			}
		}
		#endregion
	}
}