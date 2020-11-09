using System;
using System.Collections.Generic;
using System.Text;


    public class Gun2:GunFactory
    {
    public void Start()
    {
        ShootMutiple(4, 4);
    }
    public void Update()
    {
        Shoot();
    }
}
