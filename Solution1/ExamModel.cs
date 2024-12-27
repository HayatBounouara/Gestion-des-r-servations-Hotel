using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Solution1
{
    public class ExamModel : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ExamModel » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Solution1.ExamModel » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ExamModel » dans le fichier de configuration de l'application.
        public ExamModel()
            : base("name=ExamModel")
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Sejour> Sejours { get; set; }
     //  public virtual DbSet<Reservationannulee> Reservationannulees { get; set; }


        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    [Table("clients")]
    public class Client
    {
        [Column("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }
        [Column("NomClient")]
     
        public string NomClient { get; set; }
        [Column("AdresseClient")]
        public string AdresseClient { get; set; }
        [Column("TelClient")]
        public string TelClient { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        //public virtual ICollection<Reservationannulee> Reservationannulees { get; set; }
         


    }

    [Table("reservations")]
    public class Reservation
    {
        [Column("CodeReservation")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodeReservation { get; set; }
        [Column("Date")]
       
        public DateTime Date { get; set; }
        [Column("Pensioncomplete")]
        public string Pensioncomplete { get; set; }
        [ForeignKey("Client")]

         public int IdClient { get; set; }
        public Client Client { get; set; }
        
        public virtual ICollection<Sejour> Sejours { get; set; }
       // public virtual ICollection<Reservationannulee> Reservationannulees { get; set; }

    }

    [Table("sejours")]
    public class Sejour
    {
        [Column("Numsejour")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numsejour { get; set; }
        [Column("DateSejour")]

        public DateTime DateSejour { get; set; }
        [Column("TypeSejour")]
        public string TypeSejour { get; set; }
        [Column("DureeSejour")]
        public string DureeSejour { get; set; }


        [ForeignKey("Reservation")]

        public int CodeReservation { get; set; }
        public Reservation Reservation { get; set; }
    }
/*
    public class Reservationannulee
    {
        [ForeignKey("Reservation")]
        public int CodeReservation { get; set; }
        [ForeignKey("Client")]
        public int IdClient { get; set; }
        [Key]
        public DateTime Annulation { get; set; }

        public virtual Reservation Reservation { get; set; }
        public virtual Client Client { get; set; }


    }
*/



    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}