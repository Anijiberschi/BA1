class Program
{
	public static void main(String[] args)
	{
		Point A = new Point('A',5,3);
		Point B = new Point('B',2,6);
		Point C = new Point('C',4,7); 
		
		A.afficheCoord();
		System.out.println(A.distance(B));
		A.deplacer(3,6.2);
		A.afficheCoord();
		
		System.out.println(A.alignement(B,C));
	}
}