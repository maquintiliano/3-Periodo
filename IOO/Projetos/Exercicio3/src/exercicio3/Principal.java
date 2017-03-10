/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio3;

import java.util.Scanner;

/**
 *
 * @author Jóta
 */
public class Principal {
  
    public static void main(String[]args){
    
        //invoca classe scaner para receber entrada de dados
        Scanner sc = new Scanner (System.in);
        
        //objeto da classe animal
        Animal objAnimal = new Animal();
        
        System.out.print("Nome cientifico: ");
        objAnimal.setnomeCientifico(sc.next());
        System.out.print("Nome popular: ");
        objAnimal.setnomePopular(sc.next());
        System.out.print("Mamifero? ");
        objAnimal.setmamifero(sc.nextBoolean());
        
        //objeto da classe imóveis
        Imoveis objImoveis = new Imoveis();
        
        System.out.print("Descrição: ");
        objImoveis.setDescricao(sc.next());
        System.out.print("Quantidade de quartos: ");
        objImoveis.setqtdQuartos(sc.nextInt());
        System.out.print("Area: ");
        objImoveis.setArea(sc.nextDouble());
        System.out.print("Vagas na garagem: ");
        objImoveis.setvagasGaragem(sc.nextInt());
        
        //obj da classe pessoas
        Pessoas objPessoas = new Pessoas();
        
        System.out.print("Nome: ");
        objPessoas.setNome(sc.next());
        System.out.print("CPF: ");
        objPessoas.setCpf(sc.nextInt());
        System.out.print("RG: ");
        objPessoas.setRg(sc.next());
        System.out.print("Telefone: ");
        objPessoas.setTelefone(sc.nextInt());
   } 
}
