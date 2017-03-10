/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Aula04Ex03;

import java.util.Scanner;

/**
 *
 * @author 11161103810
 */
public class Aplicacao {
    
    public static void main (String[] args){
        
        Scanner sc = new Scanner (System.in);
        
        Piscina objPiscina = new Piscina ();
        
        System.out.println("----- PISCINA -----");
        System.out.println("Largura: ");
        objPiscina.setLargura(sc.nextDouble());
        System.out.println("Comprimento: ");
        objPiscina.setComprimento(sc.nextDouble());
        System.out.println("Profundidade: ");
        objPiscina.setProfundidade(sc.nextDouble());
        
        System.out.println("Volume: " +objPiscina.calcularVolume());
        
    }
    
}
