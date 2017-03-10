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
public class Animal {
    
    //atributos da classe animal
    private String nomeCientifico;
    private String nomePopular;
    private boolean mamifero;
    
    //escrita //setar
    
    public void setNomeCientifico (String nomeCientifico){
        this.nomeCientifico = nomeCientifico;
    }
    
    public String getNomeCientifico () {
        return nomeCientifico;
    }
    
    public void setNomePopular (String nomePopular){
        this.nomePopular = nomePopular;
    }
    
    public String getNomePopular(){
        return nomePopular;
    }
    
    public void setMamifero (boolean mamifero){
        this.mamifero = mamifero;
    }
    
    public boolean getMamifero () {
        return mamifero;
    }
    
}
