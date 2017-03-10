/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package piscina;
import java.util.Scanner;


/**
 *
 * @author Jóta
 */
public class Piscina {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        //invoca classe scaner para receber entrada de dados
        Scanner sc = new Scanner (System.in);

        //obj da classe aplicação
        Aplicacao objApp = new Aplicacao();
        
        System.out.print("Largura: ");
        objApp.setLargura(sc.nextDouble());
        System.out.print("Comprimento: ");
        objApp.setComprimento(sc.nextDouble());
        System.out.print("Profundidade: ");
        objApp.setProfundidade(sc.nextDouble());      
        
        System.out.println("O Volume é: " + objApp.calcVolume());
    }
    
}
