// See https://aka.ms/new-console-template for more information
namespace calcSE{
    class Program {
    public static void Main (string[] args) {
    //Console.WriteLine("Olá");
    //calcSE cs = new calcSE();
    //float x = cs.somar(2,3);
    //x = x + 1;
    //Console.WriteLine(x);
    calcula ca = new calcula("Verde");
    calcula ca2 = new calcula("Azul");
    calcula ca3 =  new calcula("Azul");
    Console.WriteLine(ca.getCor());
    //ca.setCor("Azul");
    Console.WriteLine(ca2.getCor());
    Console.WriteLine(ca.somar(2,3));
    Console.WriteLine(ca.somar(2,3));
    Console.WriteLine(ca.somar(2,3));
    //QUAL É O ESTADO DO OBJETO CA?
    /*cadeira c1 = new cadeira("Azul");
    cadeira c2 = new cadeira("Azul");
    cadeira c3 = new cadeira("Azul");
    cadeira c4 = new cadeira("Azul");
    cadeira c5 = new cadeira("Azul");*/
  }
}
public class calcSE{
public float somar(float v, float v2){
    return v + v2;
    }
}
public class calcula{
    private float v1;
    private float v2;
    private string cor;
public calcula(string cor){
    this.cor = cor;
}
public float somar(float v1, float v2){
    this.v1 = v1;
    this.v2 = v2;
    return this.v1 + this.v2;
}
public string getCor(){
    return this.cor;
}
public void setCor(string cor){
    this.cor = cor;
}
}
public class cadeira{
        private string cor;

public cadeira(string cor){
    this.cor = cor;
}
public string getCor(){
	return this.cor;
}
}
}