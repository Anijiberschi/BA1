public class PointColore extends Point {
    
    private String color;

    public PointColore() {
        this("blanc",0,0,'z');
    }

    public PointColore(String color,double x, double y, char nom){

        super(x,y,nom);
        this.color=color;

    }
    public PointColore(double x, double y) {
        this("blanc",x,y,'z');
    } // Marche car y a constructeur avec super au dessus.


    public String getColor() {
        return color;
    }

    public void afficher(){
        System.out.println("Le point " + getNom() + " a pour coordonnées x:" + getX() + ", y:" + getY() + " et sa couleur est "+ this.color);
    }

    @Override
    public String toString(){
        return super.toString() + "couleur = "+color;
    }

}
