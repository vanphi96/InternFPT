/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package baid;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author phi.levan
 */
public class Processing implements Runnable {

    public String mess;
    public List<Object> data;

    public Processing() {
        data = new ArrayList<>();
        mess = null;
    }

    @Override
    public void run() {
        int m = (int) data.get(0);
        if (m == 1) {
            mess = "YES";
            return;
        } else if (m == 2) {
            if (data.get(1).toString() == data.get(2).toString()) {
                mess = "YES";
                return;
            } else {
                mess = "NO";
                return;
            }
        } else {
            boolean a = true;
            for (int j = 1; j < m / 2 + 1; j++) {
                if (data.get(j).toString() != data.get(m - j - 1).toString()) {
                    a = false;
                    break;
                }
            }
            if (a) {
                mess = "YES";
                return;
            } else {
                mess = "NO";
                return;
            }
        }

    }

}
