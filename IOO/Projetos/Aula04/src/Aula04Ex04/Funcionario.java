/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Aula04Ex04;

/**
 *
 * @author 11161103810
 */
public class Funcionario {
    
    private String nome;
    private String cargo;
    private double salario;
    private double novoSalario;
    double salarioF;
    
   /* public void setSalarioF(double salarioF){
        this.salarioF = salarioF;
    }
    
    public double getSalarioF(){
        return salarioF;
    }*/
    
    public void setNome(String nome) {
        this.nome = nome;
    }
    
    public String getNome() {
        return nome;
    }

    public void setCargo (String cargo){
        this.cargo = cargo;
    }

    public String getCargo() {
        return cargo;
    }
    
    public void setSalario (double salario){
        this.salario = salario;
    }
    
    public double getSalario(){
        return salario;
    }
    
    public void setNovoSalario (double novoSalario){
        this.novoSalario = novoSalario; 
    }
    
    public double getNovoSalario(){
        return novoSalario;
    }
    
    public double calcularSalario(){
        if(cargo.equalsIgnoreCase("junior")){
            salario = 1700.0;
            
        }else
            if(cargo.equalsIgnoreCase("senior")){
                salario = 3500.0;
            }else
                if(cargo.equalsIgnoreCase("pleno")){
                    salario = 5200.0;
                }
        
        return salario;
    }
    
    public double calcularDescontoIRPF(){
       if(salario <= 1710.78){
           novoSalario = salario;
       
       } else
           if(salario >=1710.79 & salario <=2563.91){
                novoSalario = salario * 0.75;
               
             } else
                if(salario >=2563.92 & salario <= 3418.59){
                     novoSalario = salario * 0.15;                   
                
                } else
                    if(salario >= 3418.60 & salario <= 4271.59){
                        novoSalario = salario * 0.225;
                    
                    } else {
                        novoSalario = salario * 0.275;                        
                    }
       return novoSalario;
    }
    
    public double salarioFinal(){
           salarioF = salario - novoSalario;
           return salarioF;
    }
}


