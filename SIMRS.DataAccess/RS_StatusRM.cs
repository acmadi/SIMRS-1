///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'RS_StatusRM'
// Generated by LLBLGen v1.21.2003.712 Final on: 10 Desember 2007, 14:53:47
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace SIMRS.DataAccess
{
	/// <summary>
	/// Purpose: Data Access class for the table 'RS_StatusRM'.
	/// </summary>
	public class RS_StatusRM : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		_createdDate, _modifiedDate;
			private SqlInt32		_createdBy, _modifiedBy, _ordering, _jenisPoliklinikId, _statusRMId;
			private SqlString		_keterangan, _nama;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public RS_StatusRM()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>StatusRMId</LI>
		///		 <LI>JenisPoliklinikId. May be SqlInt32.Null</LI>
		///		 <LI>Nama. May be SqlString.Null</LI>
		///		 <LI>Keterangan. May be SqlString.Null</LI>
		///		 <LI>Ordering. May be SqlInt32.Null</LI>
		///		 <LI>CreatedBy. May be SqlInt32.Null</LI>
		///		 <LI>CreatedDate. May be SqlDateTime.Null</LI>
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
			cmdToExecute.CommandText = "dbo.[RS_StatusRM_Insert]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@StatusRMId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _statusRMId));
				cmdToExecute.Parameters.Add(new SqlParameter("@JenisPoliklinikId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _jenisPoliklinikId));
				cmdToExecute.Parameters.Add(new SqlParameter("@Nama", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _nama));
				cmdToExecute.Parameters.Add(new SqlParameter("@Keterangan", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _keterangan));
				cmdToExecute.Parameters.Add(new SqlParameter("@Ordering", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _ordering));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _createdBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _createdDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _modifiedBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _modifiedDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'RS_StatusRM_Insert' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("RS_StatusRM::Insert::Error occured.", ex);
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
		///		 <LI>StatusRMId</LI>
		///		 <LI>JenisPoliklinikId. May be SqlInt32.Null</LI>
		///		 <LI>Nama. May be SqlString.Null</LI>
		///		 <LI>Keterangan. May be SqlString.Null</LI>
		///		 <LI>Ordering. May be SqlInt32.Null</LI>
		///		 <LI>CreatedBy. May be SqlInt32.Null</LI>
		///		 <LI>CreatedDate. May be SqlDateTime.Null</LI>
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
			cmdToExecute.CommandText = "dbo.[RS_StatusRM_Update]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@StatusRMId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _statusRMId));
				cmdToExecute.Parameters.Add(new SqlParameter("@JenisPoliklinikId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _jenisPoliklinikId));
				cmdToExecute.Parameters.Add(new SqlParameter("@Nama", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _nama));
				cmdToExecute.Parameters.Add(new SqlParameter("@Keterangan", SqlDbType.VarChar, 255, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _keterangan));
				cmdToExecute.Parameters.Add(new SqlParameter("@Ordering", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _ordering));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _createdBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _createdDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedBy", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _modifiedBy));
				cmdToExecute.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _modifiedDate));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'RS_StatusRM_Update' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("RS_StatusRM::Update::Error occured.", ex);
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
		///		 <LI>StatusRMId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	cmdToExecute = new SqlCommand();
			cmdToExecute.CommandText = "dbo.[RS_StatusRM_Delete]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@StatusRMId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _statusRMId));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				_rowsAffected = cmdToExecute.ExecuteNonQuery();
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'RS_StatusRM_Delete' reported the ErrorCode: " + _errorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("RS_StatusRM::Delete::Error occured.", ex);
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
		///		 <LI>StatusRMId</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>StatusRMId</LI>
		///		 <LI>JenisPoliklinikId</LI>
		///		 <LI>Nama</LI>
		///		 <LI>Keterangan</LI>
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
			cmdToExecute.CommandText = "dbo.[RS_StatusRM_SelectOne]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("RS_StatusRM");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

			// Use base class' connection object
			cmdToExecute.Connection = _mainConnection;

			try
			{
				cmdToExecute.Parameters.Add(new SqlParameter("@StatusRMId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _statusRMId));
				cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

				// Open connection.
				_mainConnection.Open();

				// Execute query.
				adapter.Fill(toReturn);
				_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

				if(_errorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'RS_StatusRM_SelectOne' reported the ErrorCode: " + _errorCode);
				}

				if(toReturn.Rows.Count > 0)
				{
					_statusRMId = (Int32)toReturn.Rows[0]["StatusRMId"];
					_jenisPoliklinikId = toReturn.Rows[0]["JenisPoliklinikId"] == System.DBNull.Value ? SqlInt32.Null : (Int32)toReturn.Rows[0]["JenisPoliklinikId"];
					_nama = toReturn.Rows[0]["Nama"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["Nama"];
					_keterangan = toReturn.Rows[0]["Keterangan"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["Keterangan"];
					_ordering = toReturn.Rows[0]["Ordering"] == System.DBNull.Value ? SqlInt32.Null : (Int32)toReturn.Rows[0]["Ordering"];
					_createdBy = toReturn.Rows[0]["CreatedBy"] == System.DBNull.Value ? SqlInt32.Null : (Int32)toReturn.Rows[0]["CreatedBy"];
					_createdDate = toReturn.Rows[0]["CreatedDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)toReturn.Rows[0]["CreatedDate"];
					_modifiedBy = toReturn.Rows[0]["ModifiedBy"] == System.DBNull.Value ? SqlInt32.Null : (Int32)toReturn.Rows[0]["ModifiedBy"];
					_modifiedDate = toReturn.Rows[0]["ModifiedDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)toReturn.Rows[0]["ModifiedDate"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("RS_StatusRM::SelectOne::Error occured.", ex);
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
			cmdToExecute.CommandText = "dbo.[RS_StatusRM_SelectAll]";
			cmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("RS_StatusRM");
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
					throw new Exception("Stored Procedure 'RS_StatusRM_SelectAll' reported the ErrorCode: " + _errorCode);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("RS_StatusRM::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				_mainConnection.Close();
				cmdToExecute.Dispose();
				adapter.Dispose();
			}
		}

        public DataTable GetListWJenisPoliklinikId()
        {
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[RS_StatusRM_GetListWJenisPoliklinikId]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("RS_StatusRM");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@JenisPoliklinikId", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _jenisPoliklinikId));
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                // Open connection.
                _mainConnection.Open();

                // Execute query.
                adapter.Fill(toReturn);
                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'RS_StatusRM_GetListWJenisPoliklinikId' reported the ErrorCode: " + _errorCode);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("RS_StatusRM::GetListWJenisPoliklinikId::Error occured.", ex);
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
		public SqlInt32 StatusRMId
		{
			get
			{
				return _statusRMId;
			}
			set
			{
				SqlInt32 statusRMIdTmp = (SqlInt32)value;
				if(statusRMIdTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("StatusRMId", "StatusRMId can't be NULL");
				}
				_statusRMId = value;
			}
		}


		public SqlInt32 JenisPoliklinikId
		{
			get
			{
				return _jenisPoliklinikId;
			}
			set
			{
				_jenisPoliklinikId = value;
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


		public SqlInt32 Ordering
		{
			get
			{
				return _ordering;
			}
			set
			{
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
