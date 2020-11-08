using System;
using System.Collections.Generic;
using System.Text;


    public class Gun1:GunFactory
    {
    public void Start()
    {
        ShootMutiple(2,2);
    }
    public void Update()
    {
        Shoot();
    }

}
