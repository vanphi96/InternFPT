/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package baic;

import java.util.Scanner;

/**
 *
 * @author phi.levan
 */
public class BaiC {

    /**
     * @param args the command line arguments
     */
    boolean nto(long x) {
        if (x < 2) {
            return false;
        }
        for (long i = 2; i <= Math.sqrt(x); i++) {
            if (x % i == 0) {
                return false;
            }
        }
        return true;
    }

    boolean ktra(long x) {
        long tong = 0;
        boolean cs = true;
        while (x > 0) {
            long t = x % 10;
            if (t != 2 && t != 3 && t != 5 && t != 7) {
                cs = false;
            }
            tong = tong + t;
            x = x / 10;
        }
        if (nto(tong) && cs == true) {
            return true;
        }
        return false;
    }
    void process(){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        long[] inP = new long[n*2];
        int[] dem= new int[n];
        for(int i=0; i<n; i++){
//            inP[dem]= sc.nextLong();
//            dem++;
//            inP[dem]= sc.nextLong();
//            dem++;
               long a=sc.nextLong();
               long b=sc.nextLong();
               if(a<b){
                   for(long j=a; j<=b; j++){
                       if(ktra(j)&&nto(j)){
                           dem[i]++;
                       }
                   }
               }
               else{
                  dem[i]=-1; 
               }
              
        }
        for (int i = 0; i < n; i++) {
            System.out.println(dem[i]);
        }
    }

    public static void main(String[] args) {
        BaiC baiC = new BaiC();
        baiC.process();
    }

}
