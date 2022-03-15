class Program
{
	public static void main(String[] args)
	{
		Voiture auto = new Voiture("Fiat",150,70);
		
		
		System.out.println(auto.get_description());
		
		
		Booster booster = new Booster("Deltax2", 50);
		
		booster.boost_voiture(auto);
		
		System.out.println(auto.get_description());
	}
}