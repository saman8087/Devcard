namespace DevCard.Models
{
	public class Services
	{
		public Services(long id, string name)
		{
			Id = id;
			Name = name;
		}

		public long Id { get; set; }
		public string Name { get; set; }
	}
}
