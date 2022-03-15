 
public class Point{
	
	private double x;
	private double y;
	private char letter;


	public Point (char letter,double x, double y)
	{
		this.letter=letter;
		this.x=x;
		this.y=y;
	}
	
	public Point ()
	{
		this('Z',-1,-2);  
	}
	
	 public double distance(Point b)
	{
		double d = Math.sqrt(Math.pow(b.get_x()-x,2)+Math.pow(b.get_y()-y,2));
		return d;
	}
	
	public boolean alignement(Point b,Point c)
	{
		
		return ((b.get_y()-y)/(b.get_x()-x)==(c.get_y()-y)/(c.get_x()-x));
	}  
	
	public void deplacer(double dx,double dy)
	{	
		this.x=dx-x;
		this.y=dy-y;
	}	
	
	
	public double get_x ()
	{
		return x; 
	}
	
	public double get_y ()
	{
		return y; 
	}
	
	
	public void afficheCoord()
	{
		System.out.println(letter+" a comme cordonnee x : "+x+" et comme cordonnee y :"+y+" .");
		
	}
 
	
}