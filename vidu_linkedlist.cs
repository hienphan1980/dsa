using System;
using System.Collections;

public class phantu {
    int giatri;
    phantu phantu_ke;
    
    public phantu(int gt) {
        giatri = gt;
        phantu_ke = null;
    }
}

public class danhsachlienket {
    phantu dau_danhsach;
    
    public danhsachlienket(phantu pt_dau) {
        dau_danhsach = pt_dau;
    }
    
    public phantu tim(int gt) {
        phantu pt_i = dau_danhsach;
        while (pt_i != null) {
            if (pt_i.giatri == gt) break;
            else pt_i = pt_i.phantu_ke;
        }
        return pt_i;
    } 
}



class run_linkedlist{
    static void Main(){
        
    }
} 