/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package conta;
/**
 *
 * @author Jóta
 */
class Cc {
    int numero; 
    String dono;
    double saldo;
    double limite;
    double salario;
    
    void saca(double quantidade) {
        double novoSaldo = this.saldo - quantidade;
        this.saldo = novoSaldo;
}
}
public class Conta {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        Cc minhaCc;
	minhaCc = new Cc();
        
        minhaCc.dono ="Duke";
        minhaCc.saldo = 1000.0;
        
        System.out.println("Saldo atual: "+minhaCc.saldo);
    }   
}
