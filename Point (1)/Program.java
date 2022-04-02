public class Program
{
	public static void main(String[] args)
	{
          Point p1 = new Point(-1,-1,'A');
		  p1.afficheCoord();
		  
		  Point p2 = new Point(1,1,'B');
		  p2.afficheCoord();
		  
		  p2.deplacer(4, 4);
		  p2.afficheCoord();
		  
		  System.out.println("Distance entre p1 et p2 : " + p2.distance(p1));
		  System.out.println("Distance entre p1 et p2 : " + Point.distance(p1,p2));
		  
		  Point p3 = new Point(2,2,'C');
		  
		  System.out.println( "P3,P2 et P1 sont il alignés ? : " + p3.alignement(p2,p1));
		  System.out.println( "P3,P2 et P1 sont il alignés ? : " + Point.alignement(p1,p2,p3));
	}
}