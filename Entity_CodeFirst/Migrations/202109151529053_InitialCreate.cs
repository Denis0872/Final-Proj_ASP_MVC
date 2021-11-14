namespace Entity_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.animals",
                c => new
                    {
                        idAnimals = c.Int(nullable: false, identity: true),
                        KindAnimals = c.Int(nullable: false),
                        Shelter = c.Int(nullable: false),
                        InfoAnimals = c.Int(nullable: false),
                        Treatment = c.Int(nullable: false),
                        infoaboutanimal_IdinfoAboutAnimal = c.Int(),
                        kindanimals1_idkindAnimals = c.Int(),
                        shelter1_idshelter = c.Int(),
                        treatment1_idtreatment = c.Int(),
                    })
                .PrimaryKey(t => t.idAnimals)
                .ForeignKey("dbo.infoaboutanimals", t => t.infoaboutanimal_IdinfoAboutAnimal)
                .ForeignKey("dbo.kindanimals", t => t.kindanimals1_idkindAnimals)
                .ForeignKey("dbo.shelters", t => t.shelter1_idshelter)
                .ForeignKey("dbo.treatments", t => t.treatment1_idtreatment)
                .Index(t => t.infoaboutanimal_IdinfoAboutAnimal)
                .Index(t => t.kindanimals1_idkindAnimals)
                .Index(t => t.shelter1_idshelter)
                .Index(t => t.treatment1_idtreatment);
            
            CreateTable(
                "dbo.infoaboutanimals",
                c => new
                    {
                        IdinfoAboutAnimal = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Durationin_in__helter_in_monthes = c.String(),
                        Deseases = c.String(),
                        SizeAnimal = c.Int(nullable: false),
                        PhotoAnimal = c.String(),
                        deseases1_iddeseases = c.Int(),
                    })
                .PrimaryKey(t => t.IdinfoAboutAnimal)
                .ForeignKey("dbo.deseases", t => t.deseases1_iddeseases)
                .Index(t => t.deseases1_iddeseases);
            
            CreateTable(
                "dbo.deseases",
                c => new
                    {
                        iddeseases = c.Int(nullable: false, identity: true),
                        desease = c.String(),
                    })
                .PrimaryKey(t => t.iddeseases);
            
            CreateTable(
                "dbo.kindanimals",
                c => new
                    {
                        idkindAnimals = c.Int(nullable: false, identity: true),
                        KindAnimal = c.String(),
                        SizeAnimal = c.String(),
                        Feeding = c.Int(),
                        feeding1_idfeeding = c.Int(),
                    })
                .PrimaryKey(t => t.idkindAnimals)
                .ForeignKey("dbo.feedings", t => t.feeding1_idfeeding)
                .Index(t => t.feeding1_idfeeding);
            
            CreateTable(
                "dbo.feedings",
                c => new
                    {
                        idfeeding = c.Int(nullable: false, identity: true),
                        ingredient = c.String(),
                    })
                .PrimaryKey(t => t.idfeeding);
            
            CreateTable(
                "dbo.peopleinfoes",
                c => new
                    {
                        idpeopleInfo = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        kindAnimals = c.Int(),
                        region = c.Int(),
                        kindanimals1_idkindAnimals = c.Int(),
                        region1_idregion = c.Int(),
                    })
                .PrimaryKey(t => t.idpeopleInfo)
                .ForeignKey("dbo.kindanimals", t => t.kindanimals1_idkindAnimals)
                .ForeignKey("dbo.regions", t => t.region1_idregion)
                .Index(t => t.kindanimals1_idkindAnimals)
                .Index(t => t.region1_idregion);
            
            CreateTable(
                "dbo.regions",
                c => new
                    {
                        idregion = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.idregion);
            
            CreateTable(
                "dbo.shelters",
                c => new
                    {
                        idshelter = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Phone = c.String(),
                        LimitAnimals = c.String(),
                        CountAnimals = c.String(),
                        idRegion = c.Int(),
                    })
                .PrimaryKey(t => t.idshelter)
                .ForeignKey("dbo.regions", t => t.idRegion)
                .Index(t => t.idRegion);
            
            CreateTable(
                "dbo.treatments",
                c => new
                    {
                        idtreatment = c.Int(nullable: false, identity: true),
                        treatment1 = c.String(),
                        Data_start = c.DateTime(),
                        Data_Final = c.DateTime(),
                        address = c.String(),
                        region = c.Int(),
                        region1_idregion = c.Int(),
                    })
                .PrimaryKey(t => t.idtreatment)
                .ForeignKey("dbo.regions", t => t.region1_idregion)
                .Index(t => t.region1_idregion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.treatments", "region1_idregion", "dbo.regions");
            DropForeignKey("dbo.animals", "treatment1_idtreatment", "dbo.treatments");
            DropForeignKey("dbo.shelters", "idRegion", "dbo.regions");
            DropForeignKey("dbo.animals", "shelter1_idshelter", "dbo.shelters");
            DropForeignKey("dbo.peopleinfoes", "region1_idregion", "dbo.regions");
            DropForeignKey("dbo.peopleinfoes", "kindanimals1_idkindAnimals", "dbo.kindanimals");
            DropForeignKey("dbo.kindanimals", "feeding1_idfeeding", "dbo.feedings");
            DropForeignKey("dbo.animals", "kindanimals1_idkindAnimals", "dbo.kindanimals");
            DropForeignKey("dbo.infoaboutanimals", "deseases1_iddeseases", "dbo.deseases");
            DropForeignKey("dbo.animals", "infoaboutanimal_IdinfoAboutAnimal", "dbo.infoaboutanimals");
            DropIndex("dbo.treatments", new[] { "region1_idregion" });
            DropIndex("dbo.shelters", new[] { "idRegion" });
            DropIndex("dbo.peopleinfoes", new[] { "region1_idregion" });
            DropIndex("dbo.peopleinfoes", new[] { "kindanimals1_idkindAnimals" });
            DropIndex("dbo.kindanimals", new[] { "feeding1_idfeeding" });
            DropIndex("dbo.infoaboutanimals", new[] { "deseases1_iddeseases" });
            DropIndex("dbo.animals", new[] { "treatment1_idtreatment" });
            DropIndex("dbo.animals", new[] { "shelter1_idshelter" });
            DropIndex("dbo.animals", new[] { "kindanimals1_idkindAnimals" });
            DropIndex("dbo.animals", new[] { "infoaboutanimal_IdinfoAboutAnimal" });
            DropTable("dbo.treatments");
            DropTable("dbo.shelters");
            DropTable("dbo.regions");
            DropTable("dbo.peopleinfoes");
            DropTable("dbo.feedings");
            DropTable("dbo.kindanimals");
            DropTable("dbo.deseases");
            DropTable("dbo.infoaboutanimals");
            DropTable("dbo.animals");
        }
    }
}
