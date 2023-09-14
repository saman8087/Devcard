namespace DevCard.Models
{
	public class Project
	{
	

		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Client { get; set; }
		public Project(string name, string description, string client)
		{
			Name = name;
			Description = description;
			Client = client;
		}

		public Project()
		{
		}
	}

}
