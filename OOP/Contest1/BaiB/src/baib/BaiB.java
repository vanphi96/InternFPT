/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
//package baib;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author phi.levan
 */
public class BaiB {

    /**
     * @param args the command line arguments
     */
    public List<Object> TachSo(long a){
       List<Object> objects = new ArrayList<>();
       while(a>0){
           long b=a%10;
           a=a/10;
           objects.add(b);
       }
       return objects;
    }
    public boolean checkStartEnd(List<Object> objects){
        if(objects.size()>0){
            long start = (long)objects.get(0);
            long end = (long)objects.get(objects.size()-1);
            if(start==end){
                return true;
            }
        }
        
        return false;
    }
    public List<Object> Nhap(){
        List<Object> inP = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        inP.add(n);
        for(int i=0; i<n; i++){
            long data = sc.nextLong();
            inP.add(data);
        }
        return inP;
    }
    public void Process(){
        List<Object> inP = Nhap();
        int n = (int)inP.get(0);
        List<Object> data= new ArrayList<>();
        for(int i=1; i<=n; i++){
            long a = (long)inP.get(i);
            List<Object> objects = TachSo(a);
            boolean result = checkStartEnd(objects);
            if(result){
                System.out.println("YES");
                
            }
            else{
                System.out.println("NO");
            }
        }
    }
    public static void main(String[] args) {
       BaiB baiB = new BaiB();
       baiB.Process();
    }
    
}
