public class Voiture
{
	private String Marque;
	private int Id;
	private static int cpt=0;
	private int Vitesse;
	private int Puissance;
	
	
	public  Voiture(String marque, int vitesse, int puissance)
	{
		cpt++;
		Marque=marque;
		Vitesse=vitesse;
		Puissance=puissance;
		Id+=cpt;
	}
	
	public int get_vitesse()
	{
		return Vitesse;
	}
	
	public int set_vitesse(int vitesse)
	{
		Vitesse=vitesse;
		return Vitesse;
	}
	
	public int get_puissance()
	{
		return Puissance;
	}
	
	public int set_puissance(int puissance)
	{
		Puissance=puissance;
		return Puissance;
	}
		
	String get_description()
	{
		String description="La marque de la voiture est "+Marque+",son Id est "+Id+" ,elle a une vitesse de "+Vitesse+" et une puissance de "+Puissance+".";
		return description;
	}
}