using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject Bat,Eagle,Camel,Cheetah,Deer,Boar,Crocodile,Cow,Trex,Fox,Pig,Bird,Monkey,Armadillos,Bilbies,Phyton,Loris,Goat,Horse,Phanter,Ibex,Panda,Monk,Squirel,Wolf,Puffin,Orchin,Platypus,Scorpion,Yak,ShadowBat,ShadowEagle,ShadowCamel,ShadowCheetah,ShadowDeer,ShadowBoar,ShadowCrocodile,ShadowCow,ShadowTrex,ShadowFox,ShadowPig,ShadowBird,ShadowMonkey,ShadowArmadillos,ShadowBilbies,ShadowPhyton,ShadowLoris,ShadowGoat,ShadowHorse,ShadowPhanter,ShadowIbex,ShadowPanda,ShadowMonk,ShadowSquirel,ShadowWolf,ShadowPuffin,ShadowOrchin,ShadowPlatypus,ShadowScorpion,ShadowYak;
    public GameObject youWin;
    public GameObject Complete;
    public GameObject AllLevelCompleted;
    public GameObject PhytonMassagePopUp;
    public GameObject LorisMassagePopUp;
    public GameObject GoatMassagePopUp;
    public GameObject HorseMassagePopUp;
    public GameObject PhanterMassagePopUp;
    public GameObject IbexMassagePopUp;
    public GameObject PandaMassagePopUp;
    public GameObject MonkMassagePopUp;
    public GameObject SquirelMassagePopUp;
    public GameObject WolfMassagePopUp;
    public GameObject BoarMassagePopUp;
    public GameObject CrocodileMassagePopUp;
    public GameObject CowMassagePopUp;
    public GameObject TrexMassagePopUp;
    public GameObject FoxMassagePopUp;
    public GameObject PigMassagePopUp;
    public GameObject BirdMassagePopUp;
    public GameObject MonkeyMassagePopUp;
    public GameObject ArmadillosMassagePopUp;
    public GameObject BilbiesMassagePopUp;
    public GameObject BatMassagePopUp;
    public GameObject EagleMassagePopUp;
    public GameObject CamelMassagePopUp;
    public GameObject CheetahMassagePopUp;
    public GameObject DeerMassagePopUp;


    public void ResetAll(){
        
        Camel.transform.position=CamelInitialPos;
            source.clip=incorrect;
            source.Play();
    }

    Vector2 BatInitialPos,EagleInitialPos,CamelInitialPos,CheetahInitialPos,DeerInitialPos,BoarInitialPos,CrocodileInitialPos,CowInitialPos,TrexInitialPos,FoxInitialPos,PigInitialPos,BirdInitialPos,MonkeyInitialPos,ArmadillosInitialPos,BilbiesInitialPos,PhytonInitialPos,LorisInitialPos,GoatInitialPos,HorseInitialPos,PhanterInitialPos,IbexInitialPos,PandaInitialPos,MonkInitialPos,SquirelInitialPos,WolfInitialPos,PuffinInitialPos,OrchinInitialPos,PlatypusInitialPos,ScorpionInitialPos,YakInitialPos;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioSource LevelComplete;

    bool BatCorrect,EagleCorrect,CamelCorrect,CheetahCorrect,DeerCorrect,BoarCorrect,CrocodileCorrect,CowCorrect,TrexCorrect,FoxCorrect,PigCorrect,BirdCorrect,MonkeyCorrect,ArmadillosCorrect,BilbiesCorrect,PhytonCorrect,LorisCorrect,GoatCorrect,HorseCorrect,PhanterCorrect,IbexCorrect,PandaCorrect,MonkCorrect,SquirelCorrect,WolfCorrect,PuffinCorrect,OrchinCorrect,PlatypusCorrect,ScorpionCorrect,YakCorrect;

    void Start()
    {
        BatInitialPos=Bat.transform.position;
        EagleInitialPos=Eagle.transform.position;
        CamelInitialPos=Camel.transform.position;
        CheetahInitialPos=Cheetah.transform.position;
        DeerInitialPos=Deer.transform.position;
        BoarInitialPos=Boar.transform.position;
        CrocodileInitialPos=Eagle.transform.position;
        CowInitialPos=Camel.transform.position;
        TrexInitialPos=Cheetah.transform.position;
        FoxInitialPos=Deer.transform.position;
        PigInitialPos=Boar.transform.position;
        BirdInitialPos=Camel.transform.position;
        MonkeyInitialPos=Cheetah.transform.position;
        ArmadillosInitialPos=Deer.transform.position;
        BilbiesInitialPos=Boar.transform.position;
        PhytonInitialPos=Phyton.transform.position;
        LorisInitialPos=Loris.transform.position;
        GoatInitialPos=Goat.transform.position;
        HorseInitialPos=Horse.transform.position;
        PhanterInitialPos=Phanter.transform.position;
        IbexInitialPos=Ibex.transform.position;
        PandaInitialPos=Panda.transform.position;
        MonkInitialPos=Monk.transform.position;
        SquirelInitialPos=Squirel.transform.position;
        WolfInitialPos=Wolf.transform.position;
        PuffinInitialPos=Puffin.transform.position;
        OrchinInitialPos=Orchin.transform.position;
        PlatypusInitialPos=Platypus.transform.position;
        ScorpionInitialPos=Scorpion.transform.position;
        YakInitialPos=Yak.transform.position;

    }
    public void DragCamel()
    {
        Camel.transform.position = Input.mousePosition;
    }

    public void DragBat()
    {
        Bat.transform.position = Input.mousePosition;
    }

    public void DragEagle()
    {
        Eagle.transform.position = Input.mousePosition;
    }

    public void DragCheetah()
    {
        Cheetah.transform.position = Input.mousePosition;
    }

    public void DragDeer()
    {
        Deer.transform.position = Input.mousePosition;
    }

    public void DragBoar()
    {
        Boar.transform.position = Input.mousePosition;
    }

    public void DragCrocodile()
    {
        Crocodile.transform.position = Input.mousePosition;
    }

    public void DragCow()
    {
        Cow.transform.position = Input.mousePosition;
    }

    public void DragTrex()
    {
        Trex.transform.position = Input.mousePosition;
    }

    public void DragFox()
    {
        Fox.transform.position = Input.mousePosition;
    }

    public void DragPig()
    {
        Pig.transform.position = Input.mousePosition;
    }

    public void DragBird()
    {
        Bird.transform.position = Input.mousePosition;
    }

    public void DragMonkey()
    {
        Monkey.transform.position = Input.mousePosition;
    }

    public void DragArmadillos()
    {
        Armadillos.transform.position = Input.mousePosition;
    }

    public void DragBilbies()
    {
        Bilbies.transform.position = Input.mousePosition;
    }

    public void DragPhyton()
    {
        Phyton.transform.position = Input.mousePosition;
    }

    public void DragLoris()
    {
        Loris.transform.position = Input.mousePosition;
    }

    public void DragGoat()
    {
        Goat.transform.position = Input.mousePosition;
    }

    public void DragHorse()
    {
        Horse.transform.position = Input.mousePosition;
    }

    public void DragPhanter()
    {
        Phanter.transform.position = Input.mousePosition;
    }

    public void DragIbex()
    {
        Ibex.transform.position = Input.mousePosition;
    }

    public void DragPanda()
    {
        Panda.transform.position = Input.mousePosition;
    }

    public void DragMonk()
    {
        Monk.transform.position = Input.mousePosition;
    }

    public void DragSquirel()
    {
        Squirel.transform.position = Input.mousePosition;
    }

    public void DragWolf()
    {
        Wolf.transform.position = Input.mousePosition;
    }

    public void DragPuffin()
    {
        Puffin.transform.position = Input.mousePosition;
    }

    public void DragOrchin()
    {
        Orchin.transform.position = Input.mousePosition;
    }

    public void DragPlatymus()
    {
        Platypus.transform.position = Input.mousePosition;
    }

    public void DragScorpion()
    {
        Scorpion.transform.position = Input.mousePosition;
    }

    public void DragYak()
    {
        Yak.transform.position = Input.mousePosition;
    }


    public void DropCamel()
    {
        float Distance=Vector3.Distance(Camel.transform.position,ShadowCamel.transform.position);
        if(Distance<50)
        {
            Camel.transform.position=ShadowCamel.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            CamelCorrect = true;
            CamelMassagePopUp.SetActive(true);
        }
        else
        {
            Camel.transform.position=CamelInitialPos;
            source.clip=incorrect;
            source.Play();
        }
    }

        public void DropBat()
    {
        float Distance=Vector3.Distance(Bat.transform.position,ShadowBat.transform.position);
        if(Distance<50)
        {
            Bat.transform.position=ShadowBat.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            BatCorrect = true;
            BatMassagePopUp.SetActive(true);
        }
        else
        {
            Bat.transform.position=BatInitialPos;
            source.clip=incorrect;
            source.Play();
        }
    }

        public void DropEagle()
    {
        float Distance=Vector3.Distance(Eagle.transform.position,ShadowEagle.transform.position);
        if(Distance<50)
        {
            Eagle.transform.position=ShadowEagle.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            EagleCorrect = true;
            EagleMassagePopUp.SetActive(true);
        }
        else
        {
            Eagle.transform.position=EagleInitialPos;
            source.clip=incorrect;
            source.Play();
        }
    }

        public void DropCheetah()
    {
        float Distance=Vector3.Distance(Cheetah.transform.position,ShadowCheetah.transform.position);
        if(Distance<50)
        {
            Cheetah.transform.position=ShadowCheetah.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            CheetahCorrect = true;
            CheetahMassagePopUp.SetActive(true);
        }
        else
        {
            Cheetah.transform.position=CheetahInitialPos;
            source.clip=incorrect;
            source.Play();
        }
    }
    
        public void DropDeer()
    {
        float Distance=Vector3.Distance(Deer.transform.position,ShadowDeer.transform.position);
        if(Distance<50)
        {
            Deer.transform.position=ShadowDeer.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            DeerCorrect = true;
            DeerMassagePopUp.SetActive(true);
        }
        else
        {
            Deer.transform.position=DeerInitialPos;
            source.clip=incorrect;
            source.Play();
        }
    }
        public void DropBoar()
    {
        float Distance=Vector3.Distance(Boar.transform.position,ShadowBoar.transform.position);
        if(Distance<50)
        {
            Boar.transform.position=ShadowBoar.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            BoarCorrect = true;
            BoarMassagePopUp.SetActive(true);
        }
        else
        {
            Boar.transform.position=BoarInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropCrocodile()
    {
        float Distance=Vector3.Distance(Crocodile.transform.position,ShadowCrocodile.transform.position);
        if(Distance<50)
        {
            Crocodile.transform.position=ShadowCrocodile.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            CrocodileCorrect = true;
            CrocodileMassagePopUp.SetActive(true);
        }
        else
        {
            Crocodile.transform.position=CrocodileInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropCow()
    {
        float Distance=Vector3.Distance(Cow.transform.position,ShadowCow.transform.position);
        if(Distance<50)
        {
            Cow.transform.position=ShadowCow.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            CowCorrect = true;
            CowMassagePopUp.SetActive(true);
        }
        else
        {
            Cow.transform.position=CowInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropTrex()
    {
        float Distance=Vector3.Distance(Trex.transform.position,ShadowTrex.transform.position);
        if(Distance<50)
        {
            Trex.transform.position=ShadowTrex.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            TrexCorrect = true;
            TrexMassagePopUp.SetActive(true);
        }
        else
        {
            Trex.transform.position=TrexInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropFox()
    {
        float Distance=Vector3.Distance(Fox.transform.position,ShadowFox.transform.position);
        if(Distance<50)
        {
            Fox.transform.position=ShadowFox.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            FoxCorrect = true;
            FoxMassagePopUp.SetActive(true);
        }
        else
        {
            Fox.transform.position=FoxInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropPig()
    {
        float Distance=Vector3.Distance(Pig.transform.position,ShadowPig.transform.position);
        if(Distance<50)
        {
            Pig.transform.position=ShadowPig.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            PigCorrect = true;
            PigMassagePopUp.SetActive(true);
        }
        else
        {
            Pig.transform.position=PigInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropBird()
    {
        float Distance=Vector3.Distance(Bird.transform.position,ShadowBird.transform.position);
        if(Distance<50)
        {
            Bird.transform.position=ShadowBird.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            BirdCorrect = true;
            BirdMassagePopUp.SetActive(true);
        }
        else
        {
            Bird.transform.position=BirdInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropMonkey()
    {
        float Distance=Vector3.Distance(Monkey.transform.position,ShadowMonkey.transform.position);
        if(Distance<50)
        {
            Monkey.transform.position=ShadowMonkey.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            MonkeyCorrect = true;
            MonkeyMassagePopUp.SetActive(true);
        }
        else
        {
            Monkey.transform.position=MonkeyInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropArmadillos()
    {
        float Distance=Vector3.Distance(Armadillos.transform.position,ShadowArmadillos.transform.position);
        if(Distance<50)
        {
            Armadillos.transform.position=ShadowArmadillos.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            ArmadillosCorrect = true;
            ArmadillosMassagePopUp.SetActive(true);
        }
        else
        {
            Armadillos.transform.position=ArmadillosInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        public void DropBilbies()
    {
        float Distance=Vector3.Distance(Bilbies.transform.position,ShadowBilbies.transform.position);
        if(Distance<50)
        {
            Bilbies.transform.position=ShadowBilbies.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            BilbiesCorrect = true;
            BilbiesMassagePopUp.SetActive(true);
        }
        else
        {
            Bilbies.transform.position=BilbiesInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropPhyton()
    {
        float Distance=Vector3.Distance(Phyton.transform.position,ShadowPhyton.transform.position);
        if(Distance<50)
        {
            Phyton.transform.position=ShadowPhyton.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            PhytonCorrect = true;
            PhytonMassagePopUp.SetActive(true);
        }
        else
        {
            Phyton.transform.position=PhytonInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropLoris()
    {
        float Distance=Vector3.Distance(Loris.transform.position,ShadowLoris.transform.position);
        if(Distance<50)
        {
            Loris.transform.position=ShadowLoris.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            LorisCorrect = true;
            LorisMassagePopUp.SetActive(true);
        }
        else
        {
            Loris.transform.position=LorisInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropGoat()
    {
        float Distance=Vector3.Distance(Goat.transform.position,ShadowGoat.transform.position);
        if(Distance<50)
        {
            Goat.transform.position=ShadowGoat.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            GoatCorrect = true;
            GoatMassagePopUp.SetActive(true);
        }
        else
        {
            Goat.transform.position=GoatInitialPos;
            source.clip=incorrect;
            source.Play();
          
        } 
    }
        
        public void DropHorse()
    {
        float Distance=Vector3.Distance(Horse.transform.position,ShadowHorse.transform.position);
        if(Distance<50)
        {
            Horse.transform.position=ShadowHorse.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            HorseCorrect = true;
            HorseMassagePopUp.SetActive(true);
        }
        else
        {
            Horse.transform.position=HorseInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropPhanter()
    {
        float Distance=Vector3.Distance(Phanter.transform.position,ShadowPhanter.transform.position);
        if(Distance<50)
        {
            Phanter.transform.position=ShadowPhanter.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            PhanterCorrect = true;
            PhanterMassagePopUp.SetActive(true);
        }
        else
        {
            Phanter.transform.position=PhanterInitialPos;
            source.clip=incorrect;
            source.Play();
          
        } 
    }
        
        public void DropIbex()
    {
        float Distance=Vector3.Distance(Ibex.transform.position,ShadowIbex.transform.position);
        if(Distance<50)
        {
            Ibex.transform.position=ShadowIbex.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            IbexCorrect = true;
            IbexMassagePopUp.SetActive(true);
        }
        else
        {
            Ibex.transform.position=IbexInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropPanda()
    {
        float Distance=Vector3.Distance(Panda.transform.position,ShadowPanda.transform.position);
        if(Distance<50)
        {
            Panda.transform.position=ShadowPanda.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            PandaCorrect = true;
            PandaMassagePopUp.SetActive(true);

        }
        else
        {
            Panda.transform.position=PandaInitialPos;
            source.clip=incorrect;
            source.Play();
           
        } 
    }
        
        public void DropMonk()
    {
        float Distance=Vector3.Distance(Monk.transform.position,ShadowMonk.transform.position);
        if(Distance<50)
        {
            Monk.transform.position=ShadowMonk.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            MonkCorrect = true;
            MonkMassagePopUp.SetActive(true);
        }
        else
        {
            Monk.transform.position=MonkInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropSquirel()
    {
        float Distance=Vector3.Distance(Squirel.transform.position,ShadowSquirel.transform.position);
        if(Distance<50)
        {
            Squirel.transform.position=ShadowSquirel.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            SquirelCorrect = true;
            SquirelMassagePopUp.SetActive(true);
        }
        else
        {
            Squirel.transform.position=SquirelInitialPos;
            source.clip=incorrect;
            source.Play();
            
        } 
    }
        
        public void DropWolf()
    {
        float Distance=Vector3.Distance(Wolf.transform.position,ShadowWolf.transform.position);
        if(Distance<50)
        {
            Wolf.transform.position=ShadowWolf.transform.position;
            source.clip=correct[Random.Range(0,correct.Length)];
            source.Play();
            WolfCorrect = true;
            WolfMassagePopUp.SetActive(true);
        }
        else
        {
            Wolf.transform.position=WolfInitialPos;
            source.clip=incorrect;
            source.Play();
          
            
        } 
    }
        public void DropPuffin()
    {
        
            Puffin.transform.position=PuffinInitialPos;
            source.clip=incorrect;
            source.Play();
           
        
    }
        public void DropOrchin()
    {
        
            Orchin.transform.position=OrchinInitialPos;
            source.clip=incorrect;
            source.Play();

        
    }
        public void DropPlatypus()
    {
        
            Platypus.transform.position=PlatypusInitialPos;
            source.clip=incorrect;
            source.Play();
        
    }
        public void DropScorpion()
    {
       
            Scorpion.transform.position=ScorpionInitialPos;
            source.clip=incorrect;
            source.Play();
        
    }
        public void DropYak()
    {
        
      
            Yak.transform.position=YakInitialPos;
            source.clip=incorrect;
            source.Play();
        
    }

    void Update()
    {
        if(BatCorrect && EagleCorrect && CamelCorrect && CheetahCorrect && DeerCorrect)
        {
            youWin.SetActive(true);
        }

        if(BoarCorrect && CrocodileCorrect && CowCorrect && TrexCorrect && FoxCorrect && PigCorrect && BirdCorrect && MonkeyCorrect && ArmadillosCorrect && BilbiesCorrect)
        {
            Complete.SetActive(true);
        }

        if(PhytonCorrect && LorisCorrect && GoatCorrect && HorseCorrect && PhanterCorrect && IbexCorrect && PandaCorrect && MonkCorrect && SquirelCorrect && Wolf)
        {
            AllLevelCompleted.SetActive(true);
        }

    }

}

