/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aula04;

/**
 *
 * @author 11161103810
 */
public class Imovel {
    
    //atributos da classe Imovel
    
    private String descricao;
    private int quantidadeQuartos;
    private double area;
    private int vagasGaragem;
    
    public void setDescricao(String descricao){
        this.descricao = descricao;
    }
    
    public String getDescricao (){
        return descricao;
    }
    
    public void setQuantidadeQuartos (int quantidadeQuartos){
        this.quantidadeQuartos = quantidadeQuartos;
    }
    
    public int getQuantidadeQuartos (){
        return quantidadeQuartos;
    }
    
    public void setArea (double area){
        this.area = area;
    }
    
    public double getArea(){
        return area;
    }
    
    public void setVagasGaragem (int vagasGaragem){
        this.vagasGaragem = vagasGaragem;
    }
    
    public int getVagasGaragem (){
        return vagasGaragem;
    }
    
}
