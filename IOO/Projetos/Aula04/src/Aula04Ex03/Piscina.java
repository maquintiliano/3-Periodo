/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Aula04Ex03;

/**
 *
 * @author 11161103810
 */
public class Piscina {
    
    //atributos da classe Piscina
    
    private double largura;
    private double comprimento;
    private double profundidade;
    private double volume;
    
    public void setLargura(double largura){
        this.largura = largura;        
    }
    public double getLargura(){
        return largura;
    }
    public void setComprimento (double comprimento){
        this.comprimento = comprimento;
    }
    public double getComprimento (){
        return comprimento;
    }
    public void setProfundidade (double profundidade){
        this.profundidade = profundidade;
    }
    public double getProfundidade(){
        return profundidade;
    }
    
    public void setVolume (double volume){
        this.volume = volume;
    }
    public double getVolume(){
        return volume;
    }
    
    public double calcularVolume(){
        
        volume = comprimento * largura * profundidade;
        return volume;
    }
        
    
}
