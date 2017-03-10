/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio3;

/**
 *
 * @author Jóta
 */
public class Animal {
    
    //atributos ca classe animal
    private String nomeCientifico;
    private String nomePopular;
    private boolean mamifero;
    
    
    public void setnomeCientifico(String nomeCientifico){
        this.nomeCientifico = nomeCientifico;
    }
    
    public String getnomeCientifico (){
        return nomeCientifico;
    }
    
    public void setnomePopular (String nomePopular){
        this.nomePopular = nomePopular;
    }
    
    public String getnomePopular(){
        return nomePopular;
    }
    
    public void setmamifero(boolean mamifero){
        this.mamifero = mamifero;
    }
    
    public boolean getmamifero(){
        return mamifero;
    }
}
