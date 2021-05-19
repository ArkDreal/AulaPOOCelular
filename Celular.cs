namespace AulaPOOCelular
{
    public class Celular
    {

        public string modelo;

        public string cor;

        public string tamanho;

        public bool ligado = true;

        

        public bool Ligar(){
            
            return ligado = true;
        }
        
        public bool Desligar(){
            
            return ligado = false;
        }
       
        public string Fazer_Ligação(){
            
            return "Chamando...";
        }
        

        public string Enviar_Mensagem(){
            
            return "Mensagem enviada!";
        }
    }
}