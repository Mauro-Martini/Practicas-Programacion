using UnityEngine;

// Plantilla abstracta
public abstract class Superficie
{
    public abstract void OnEnter(PlayerControler controler);
    public abstract void OnExit(PlayerControler controler, float Nspeed);
}

// Suelo normal
public class SueloNormal : Superficie
{
    public override void OnEnter(PlayerControler controler)
    {
        controler.onFloor = true;
    }
    public override void OnExit(PlayerControler controler, float Nspeed)
    {
        controler.onFloor = false;
    }
}

// Suelo sticky
public class SueloSticky : Superficie
{
    public override void OnEnter(PlayerControler controler)
    {
        controler.onFloor = true;
        controler.speed *= 0.5f;
        controler.lspeed *= 0.5f;
        controler.rspeed *= 0.5f;
    }
    public override void OnExit(PlayerControler controler, float Nspeed)
    {
        controler.onFloor = false;
        controler.lspeed = -Nspeed;
        controler.rspeed = Nspeed;
        controler.speed = controler.speed < 0 ? Nspeed : -Nspeed;
    }
}
public class SueloSlippery : Superficie
{
    public override void OnEnter(PlayerControler controler)
    {
        controler.onFloor = true;
        controler.speed *= 1.3f;
        controler.lspeed *= 1.3f;
        controler.rspeed *= 1.3f;
    }
    public override void OnExit(PlayerControler controler, float Nspeed)
    {
        controler.onFloor = false;
        controler.lspeed = -Nspeed;
        controler.rspeed = Nspeed;
        controler.speed = controler.speed < 0 ? Nspeed : -Nspeed;
    }
}

// Factory
public class SuperficieFactory
{
    public static Superficie Create(string tag)
    {
        if (tag == "StickSuelo") return new SueloSticky();
        else if (tag == "SlipperySuelo") return new SueloSlippery();
        return new SueloNormal();
    }
}

// FloorDetector
public class FloorDetector : MonoBehaviour
{
    public PlayerControler controler;
    public float Nspeed;
    public WinControler wincontroler;

    void Start()
    {
        Nspeed = controler.speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (System.Array.Exists(controler.tagsSuperficie, tag => tag == other.tag))
        {
            SuperficieFactory.Create(other.tag).OnEnter(controler);
        } else if (other.CompareTag("WinPlace"))
        {
            wincontroler.Win();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (System.Array.Exists(controler.tagsSuperficie, tag => tag == other.tag))
        {
            SuperficieFactory.Create(other.tag).OnExit(controler, Nspeed);
        }
    }

}