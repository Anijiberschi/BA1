class Program
{
	public static void main(String[] args)
	{
		String [] cars ={"Volvo","BMW","Ford","Mazda"};
		
		Circular_String_Array tableau = new Circular_String_Array(cars);
		
		
		System.out.println(tableau.get_item(-0));
		
	}
}