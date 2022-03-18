public class Point
{
	protected double x;
	protected double y;
	protected char nom;
	
	public Point(double x, double y, char nom)
	{
		this.x = x;
		this.y = y;
		this.nom = nom;
	}
	
	public Point()
	{
		this(0,0,'z'); // on ré-utilise le constructeur déjà écrit avec toute la partie initialisation 
	}
	
	public void afficheCoord(String couleur)
	{
		System.out.println("Le point " + this.nom + " a pour coordonnées x:" + x + ", y:" + y );										
	}
	
	public void deplacer(double dx, double dy)
	{
		this.x += dx;
		this.y += dy;
	}
	
	public double distance(Point p)
	{
		double dist = Math.sqrt((p.x - this.x)*(p.x - this.x) + (p.y - this.y) * (p.y - this.y));
		return dist;
	}
	
	public boolean alignement(Point p1, Point p2)
	{
		//boolean estAligne = false; //         A     B
		// coeff directeur 1er  segment entre this et p1 => (p1.y - this.y) / (p1.x - this.x)
		// coeff directeur 2eme segment entre this et p2 => (p2.y - this.y) / (p2.x - this.x)
		return( ((p1.y - this.y) / (p1.x - this.x)) == ( (p2.y - this.y) / (p2.x - this.x) ));
		
	}

	// méthode de classe => statique. On pourrait donc faire : Point.distance(p1,p2)
	public static double distance(Point p1, Point p2)
	{
		double dist = Math.sqrt((p2.x - p1.x)*(p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
		return dist;
	}
	
	// méthode de classe => statique. On pourrait donc faire : Point.alignement(p1,p2,p3)
	public static boolean alignement(Point p1, Point p2, Point p3)
	{
		return( ((p1.y - p3.y) / (p1.x - p3.x)) == ( (p2.y - p3.y) / (p2.x - p3.x) ));
	}
	
	
	
	
	
	
}