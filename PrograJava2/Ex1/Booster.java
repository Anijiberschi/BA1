public class Booster
{
	private String model;
	private int boost;
	
	public Booster(String model,int boost)
	{
		this.model=model;
		this.boost=boost;
	}
	
	public void boost_voiture(Voiture auto)
	{
		int newpower=auto.get_puissance()+boost;
		int newspeed=auto.get_vitesse()*(newpower*1.0/auto.get_puissance)();
		
		
		
		auto.set_puissance(newpower);
		auto.set_vitesse(newspeed);
		
	}


}