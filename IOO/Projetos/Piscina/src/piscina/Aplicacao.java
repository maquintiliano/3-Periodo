/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package piscina;

/**
 *
 * @author Jóta
 */
public class Aplicacao {
    
    //atributos da classe piscina
    private double largura;
    private double comprimento;
    private double profundidade;
   
    
    //métodos de acesso
    public void setLargura(double largura){
        this.largura = largura;
    }
    
    public double getLargura(){
        return largura;
    }
    
    public void setComprimento(double comprimento){
        this.comprimento = comprimento;
    }
    
    public double getComprimento(){
        return comprimento;
    }
    
    public void setProfundidade(double profundidade){
        this.profundidade = profundidade;
    }
    
    public double getProfundidade (){
        return profundidade;
    }
    
    public double calcVolume(){
        double volume = comprimento*largura*profundidade;
        return volume;
        }
    
    
    
}
