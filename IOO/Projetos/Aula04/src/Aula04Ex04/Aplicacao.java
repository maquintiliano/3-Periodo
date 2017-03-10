/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Aula04Ex04;

import java.text.DateFormat;
import java.text.DecimalFormat;
import java.util.Scanner;

/**
 *
 * @author 11161103810
 */
public class Aplicacao {
    
    public static void main (String[] args){
        
        Scanner sc = new Scanner (System.in);
        
        //obj funcionario
        Funcionario objFuncionario = new Funcionario ();
        
        DecimalFormat df = new DecimalFormat("0.00");
        
        System.out.println("Nome: ");
        objFuncionario.setNome(sc.next());
        System.out.println("Cargo: ");
        objFuncionario.setCargo(sc.next()); 
        System.out.println("Salário: ");
        objFuncionario.setSalario(sc.nextDouble());
        System.out.println("Calculo IRPF: " +  df.format(objFuncionario.calcularDescontoIRPF()));
        System.out.println("Salario: " + objFuncionario.salarioFinal());
    
    }
    
}
