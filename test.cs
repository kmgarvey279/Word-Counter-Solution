public void Edit(string newDescription)
{
  MySqlConnection conn = DB.Connection();
  conn.Open();
  //Open database connection
  var cmd = conn.CreateCommand() as MySqlCommand;
  // Create new MySqlCommand object
  cmd.CommandText @"UPDATE items SET description = @newDescription WHERE id = @searchId;";
  //Set CommandText property of cmd
  //Use UPDATE statement to update items table at matching record
  mySqlParameter searchId = new MySqlParameter();
  //declare new object for parameter
  searchId.ParameterName = "@searchId";
  //parameter placeholder
  searchId.Value = _id;
  //declare value property 
  cmd.Parameters.Add(searchId);
  //insert parameters into SQL statement
  MySqlParameter description = new MySqlParameter();
  //delclare new object for parameter
  description.ParameterName = "@newDescription";
  //parameter placeholder
  description.Value = newDescription;
  //declare value property
  cmd.Parameters.Add(description);
  cmd.ExecuteNonQuery();
  //execute command
  conn.Close();

  //close database connection
  if (conn != null)
  {
    conn.Dispose();
  }
}
