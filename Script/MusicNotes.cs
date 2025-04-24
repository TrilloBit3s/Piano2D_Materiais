using UnityEngine;

public class MusicNotes : MonoBehaviour
{
    // Declarações de variáveis para armazenar referências a diferentes notas musicais graves (oitava baixa)
    [SerializeField] AudioSource lowC;
    [SerializeField] AudioSource lowD;
    [SerializeField] AudioSource lowE;
    [SerializeField] AudioSource lowF;
    [SerializeField] AudioSource lowG;
    [SerializeField] AudioSource lowA;
    [SerializeField] AudioSource lowB;
    [SerializeField] AudioSource lowCs; // Dó sustenido
    [SerializeField] AudioSource lowDs; // Ré sustenido
    [SerializeField] AudioSource lowFs; // Fá sustenido
    [SerializeField] AudioSource lowGs; // Sol sustenido
    [SerializeField] AudioSource lowAs; // Lá sustenido

    // Declarações de variáveis para armazenar referências a diferentes notas musicais agudas (oitava alta)
    [SerializeField] AudioSource highC;
    [SerializeField] AudioSource highD;
    [SerializeField] AudioSource highE;
    [SerializeField] AudioSource highF;
    [SerializeField] AudioSource highG;
    [SerializeField] AudioSource highA;
    [SerializeField] AudioSource highB;
    [SerializeField] AudioSource highCs; // Dó sustenido
    [SerializeField] AudioSource highDs; // Ré sustenido
    [SerializeField] AudioSource highFs; // Fá sustenido
    [SerializeField] AudioSource highGs; // Sol sustenido
    [SerializeField] AudioSource highAs; // Lá sustenido

    // Referência ao AudioSource que irá tocar uma música de fundo
    [SerializeField] AudioSource music;

    // Variável para controlar se a música está tocando ou não
    private bool isMusicPlaying = false;

    // Método que alterna entre tocar e parar a música de fundo
    public void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            music.Stop(); // Para a música caso já esteja tocando
        }
        else
        {
            music.Play(); // Toca a música caso não esteja tocando
        }

        // Inverte o estado da variável de controle
        isMusicPlaying = !isMusicPlaying;
    }

    // Método genérico para tocar qualquer nota musical
    public void PlayNote(AudioSource note)
    {
        note.Stop(); // Garante que a nota comece do início, mesmo que já esteja tocando
        note.Play(); // Toca o som associado ao AudioSource passado
    }

    // Métodos chamados por botões na interface para tocar as notas graves
    public void LowPressC() { PlayNote(lowC); }
    public void LowPressD() { PlayNote(lowD); }
    public void LowPressE() { PlayNote(lowE); }
    public void LowPressF() { PlayNote(lowF); }
    public void LowPressG() { PlayNote(lowG); }
    public void LowPressA() { PlayNote(lowA); }
    public void LowPressB() { PlayNote(lowB); }
    public void LowPressCs() { PlayNote(lowCs); }
    public void LowPressDs() { PlayNote(lowDs); }
    public void LowPressFs() { PlayNote(lowFs); }
    public void LowPressGs() { PlayNote(lowGs); }
    public void LowPressAs() { PlayNote(lowAs); }

    // Métodos chamados por botões na interface para tocar as notas agudas
    public void HighPressC() { PlayNote(highC); }
    public void HighPressD() { PlayNote(highD); }
    public void HighPressE() { PlayNote(highE); }
    public void HighPressF() { PlayNote(highF); }
    public void HighPressG() { PlayNote(highG); }
    public void HighPressA() { PlayNote(highA); }
    public void HighPressB() { PlayNote(highB); }
    public void HighPressCs() { PlayNote(highCs); }
    public void HighPressDs() { PlayNote(highDs); }
    public void HighPressFs() { PlayNote(highFs); }
    public void HighPressGs() { PlayNote(highGs); }
    public void HighPressAs() { PlayNote(highAs); }

    // Método para iniciar a música (ou parar), pode ser vinculado a um botão de "tocar música"
    public void StartSong()
    {
        ToggleMusic(); // Alterna o estado da música
    }
}