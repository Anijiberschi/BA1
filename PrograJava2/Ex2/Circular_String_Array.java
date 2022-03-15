public class Circular_String_Array
{

	private String [] Array;

	public Circular_String_Array(String [] array)
	{
		Array=array;
	}
	
	
	public String get_item(int i)
	{
		int taille= Array.length;
		int indice=0;
		
		if (i <0){
			indice =taille-((-1*i)%(-1*taille));
		}
		else {
			indice =i%taille;	
		}
		return Array[indice];
		
	}
	
		// public String get_item(int i)
		//Version du prof;
	// {
		// int index =i%Array.length;
		
		// if (index <0)
		// {
			// index += Array.length;
		// }
		// return Array[index];
	// }

}