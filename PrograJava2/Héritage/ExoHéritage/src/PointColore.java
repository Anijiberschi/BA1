public class PointColore extends Point {
    
    private String color;

    public PointColore(String color, double x, double y, char nom)
    {
        super(x, y, nom);
        this.color=color;
    }

    public void afficher(PointColore pc)
	{
		System.out.println("Le point " + this.nom + " a pour coordonnées x:" + x + ", y:" + y + "et sa couleur est " + color );										
	}


}
