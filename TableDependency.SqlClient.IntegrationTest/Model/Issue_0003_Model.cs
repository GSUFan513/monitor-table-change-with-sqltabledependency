﻿namespace TableDependency.SqlClient.IntegrationTest.Model
{
    public class Issue_0003_Model_Unmanaged : Issue_0003_Model_Managed
    {
        public string NotManagedColumnBecauseIsImage { get; set; }
    }

    public class Issue_0003_Model_Managed
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}