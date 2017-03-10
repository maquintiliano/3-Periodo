/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aula04;

import java.util.Scanner;

/**
 *
 * @author 11161103810
 */
public class Aula04 {

    //assinatura
    public static void main(String[] args) {
        
        Scanner sc = new Scanner (System.in);
        
        //novo objeto para classe Pessoa
        Pessoa objPessoa = new Pessoa();
        
        System.out.println("---- PESSOA ----");
        System.out.println("Nome: ");
        objPessoa.setNome(sc.next());
        System.out.println("CPF: ");
        objPessoa.setNome(sc.next());
        System.out.println("RG: ");
        objPessoa.setRg(sc.next());
        System.out.println("Telefone: ");
        objPessoa.setTelefone(sc.nextInt());
                
        //novo objeto para classe Imovel
        Imovel objImovel = new Imovel();
        
        System.out.println("---- IMÓVEL ----");
        System.out.println("Descrição: ");
        objImovel.setDescricao(sc.next());
        System.out.println("Quantidade de quartos: ");
        objImovel.setQuantidadeQuartos(sc.nextInt());
        System.out.println("Área: ");
        objImovel.setArea(sc.nextDouble());
        System.out.println("Vagas Garagem: ");
        objImovel.setVagasGaragem(sc.nextInt());
        
        //novo objeto para classe Animal
        Animal objAnimal = new Animal();

        System.out.println("---- ANIMAL ----");
        System.out.println("Nome Científico: ");
        objAnimal.setNomeCientifico(sc.next());
        System.out.println("Nome Popular: ");
        objAnimal.setNomePopular(sc.next());
        System.out.println("Mamífero: ");
        objAnimal.setMamifero(sc.nextBoolean());
        
               
        }
    
}
