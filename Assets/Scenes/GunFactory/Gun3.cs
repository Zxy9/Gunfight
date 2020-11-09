using System;
using System.Collections.Generic;
using System.Text;



    public class Gun3:GunFactory
    {

    public void Start()
    {
        ShootMutiple(3, 3);
    }
    public void Update()
    {
        Shoot();
    }
}
