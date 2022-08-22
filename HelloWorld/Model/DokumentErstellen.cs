namespace HelloWorld.Model
{
    public class Adresse
    {
        public string AdressNr { get; set; }

        public Adresse(string adressNr)
        {
            AdressNr = adressNr;
        }
    }

    public class Dokumenttyp
    {
        public string DokumenttypNr { get; set; }

        public Dokumenttyp(string dokumenttypNr)
        {
            DokumenttypNr = dokumenttypNr;
        }
    }

    public class ESRNummer
    {
        public string ESRNr { get; set; }

        public ESRNummer(string eSRNr)
        {
            ESRNr = eSRNr;
        }
    }
    public class Region
    {
        public string RegionNr { get; set; }

        public Region(string regionNr)
        {
            RegionNr = regionNr;
        }
    }

    public class Kondition
    {
        public string KonditionNr { get; set; }

        public Kondition(string konditionNr)
        {
            KonditionNr = konditionNr;
        }
    }

    public class Land
    {
        public string LandNr { get; set; }

        public Land(string landNr)
        {
            LandNr = landNr;
        }
    }

    public class Lieferadresse
    {
        public string LieferadresseNr { get; set; }

        public Lieferadresse(string lieferadresseNr)
        {
            LieferadresseNr = lieferadresseNr;
        }
    }

    public class Lieferart
    {
        public string LieferartNr { get; set; }

        public Lieferart(string lieferartNr)
        {
            LieferartNr = lieferartNr;
        }
    }

    public class LieferadressRegion
    {
        public string RegionNr { get; set; }

        public LieferadressRegion(string regionNr)
        {
            RegionNr = regionNr;
        }
    }

    public class LieferadressLand
    {
        public string LandNr { get; set; }

        public LieferadressLand(string landNr)
        {
            LandNr = landNr;
        }
    }

    public class Sammelkonto
    {
        public string KontoNr { get; set; }

        public Sammelkonto(string kontoNr)
        {
            KontoNr = kontoNr;
        }
    }

    public class Steuercode1
    {
        public string SteuercodeNr { get; set; }

        public Steuercode1(string steuercodeNr)
        {
            SteuercodeNr = steuercodeNr;
        }
    }

    public class Vertreter
    {
        public string VertreterNr { get; set; }

        public Vertreter(string vertreterNr)
        {
            VertreterNr = vertreterNr;
        }
    }

    public class Waehrung
    {
        public string WaehrungNr { get; set; }

        public Waehrung(string weaerungNr)
        {
            WaehrungNr = weaerungNr;
        }
    }

    public class Sprache
    {
        public string SpracheNr { get; set; }

        public Sprache(string spracheNr)
        {
            SpracheNr = spracheNr;
        }
    }

    public class Position
    {
        public string DokumentpositionenNr { get; set; }
        public string PositionsNR { get; set; }
        public Artikel Artikel { get; set; }
        public string Bezeichnung1 { get; set; }
        public double? Dim2 { get; set; }
        public Lagereinheit Lagereinheit { get; set; }
        public Rechnungseinheit Rechnungseinheit { get; set; }
        public double? EinkaufspreisFW { get; set; }
        public double? EinkaufspreisSW { get; set; }
        public Ertragskonto Ertragskonto { get; set; }
        public double? Gebinde { get; set; }
        public double? Gewicht { get; set; }
        public double? Inhalt { get; set; }
        public bool IstOption { get; set; }
        public double? Dim1 { get; set; }
        public int Lagerpreis { get; set; }
        public double? Marge { get; set; }
        public double? Menge { get; set; }
        public double? MengeOptional { get; set; }
        public double? MengeVerr { get; set; }
        public double? MengeVerrOptional { get; set; }
        public bool NichtAnzeigen { get; set; }
        public bool Optional { get; set; }
        public IList<string> Kundeninstallationen { get; set; }
        public int ServiceauftragspositionNr { get; set; }
        public int Positionstyp { get; set; }
        public string Preisdefinition { get; set; }
        public string PreisdefinitionZusatzartikel { get; set; }
        public double? PreisFW { get; set; }
        public double? PreisSW { get; set; }
        public double? RabattProzent { get; set; }
        public double? RabattFW { get; set; }
        public int AutomatischRechnenVon { get; set; }
        public bool Rekapitualtion { get; set; }
        public double? RueckstandMenge { get; set; }
        public Steuercode Steuercode { get; set; }
        public int Leistungsverwaltungstyp { get; set; }
        public double? SteuerFW { get; set; }
        public double? SteuerSW { get; set; }
        public IList<string> Subtotalbezeichnungen { get; set; }
        public double? Dim3 { get; set; }
        public double? TotalFW { get; set; }
        public double? TotalInklusivFW { get; set; }
        public double? TotalInklusivSW { get; set; }
        public double? TotalOptional { get; set; }
        public double? TotalSW { get; set; }
        public int Verpackungen { get; set; }
        public Vertreter Vertreter { get; set; }
        public int Zusatzartikelreferenz { get; set; }
        public bool Rechnen { get; set; }
        public bool GesamtrabattVerbuchungAufteilen { get; set; }
        public string ErstelltVon { get; set; }
        public string GeaendertVon { get; set; }

        public Position(string dokumentpositionenNr, string positionsNR, Artikel artikel, string bezeichnung1, double? dim2, Lagereinheit lagereinheit, Rechnungseinheit rechnungseinheit, double einkaufspreisFW, double einkaufspreisSW, Ertragskonto ertragskonto, double? gebinde, double? gewicht, double? inhalt, bool istOption, double? dim1, int lagerpreis, double? marge, double? menge, double? mengeOptional, double? mengeVerr, double? mengeVerrOptional, bool nichtAnzeigen, bool optional, IList<string> kundeninstallationen, int serviceauftragspositionNr, int positionstyp, string preisdefinition, string preisdefinitionZusatzartikel, double? preisFW, double? preisSW, double? rabattProzent, double? rabattFW, int automatischRechnenVon, bool rekapitualtion, double? rueckstandMenge, Steuercode steuercode, int leistungsverwaltungstyp, double? steuerFW, double? steuerSW, IList<string> subtotalbezeichnungen, double? dim3, double? totalFW, double? totalInklusivFW, double? totalInklusivSW, double? totalOptional, double? totalSW, int verpackungen, Vertreter vertreter, int zusatzartikelreferenz, bool rechnen, bool gesamtrabattVerbuchungAufteilen, string erstelltVon, string geaendertVon)
        {
            DokumentpositionenNr = dokumentpositionenNr;
            PositionsNR = positionsNR;
            Artikel = artikel;
            Bezeichnung1 = bezeichnung1;
            Dim2 = dim2;
            Lagereinheit = lagereinheit;
            Rechnungseinheit = rechnungseinheit;
            EinkaufspreisFW = einkaufspreisFW;
            EinkaufspreisSW = einkaufspreisSW;
            Ertragskonto = ertragskonto;
            Gebinde = gebinde;
            Gewicht = gewicht;
            Inhalt = inhalt;
            IstOption = istOption;
            Dim1 = dim1;
            Lagerpreis = lagerpreis;
            Marge = marge;
            Menge = menge;
            MengeOptional = mengeOptional;
            MengeVerr = mengeVerr;
            MengeVerrOptional = mengeVerrOptional;
            NichtAnzeigen = nichtAnzeigen;
            Optional = optional;
            Kundeninstallationen = kundeninstallationen;
            ServiceauftragspositionNr = serviceauftragspositionNr;
            Positionstyp = positionstyp;
            Preisdefinition = preisdefinition;
            PreisdefinitionZusatzartikel = preisdefinitionZusatzartikel;
            PreisFW = preisFW;
            PreisSW = preisSW;
            RabattProzent = rabattProzent;
            RabattFW = rabattFW;
            AutomatischRechnenVon = automatischRechnenVon;
            Rekapitualtion = rekapitualtion;
            RueckstandMenge = rueckstandMenge;
            Steuercode = steuercode;
            Leistungsverwaltungstyp = leistungsverwaltungstyp;
            SteuerFW = steuerFW;
            SteuerSW = steuerSW;
            Subtotalbezeichnungen = subtotalbezeichnungen;
            Dim3 = dim3;
            TotalFW = totalFW;
            TotalInklusivFW = totalInklusivFW;
            TotalInklusivSW = totalInklusivSW;
            TotalOptional = totalOptional;
            TotalSW = totalSW;
            Verpackungen = verpackungen;
            Vertreter = vertreter;
            Zusatzartikelreferenz = zusatzartikelreferenz;
            Rechnen = rechnen;
            GesamtrabattVerbuchungAufteilen = gesamtrabattVerbuchungAufteilen;
            ErstelltVon = erstelltVon;
            GeaendertVon = geaendertVon;
        }
    }

    public class Artikel
    {
        public string ArtikelNr { get; set; }

        public Artikel(string artikelNr)
        {
            ArtikelNr = artikelNr;
        }
    }

    public class Lagereinheit
    {
        public string EinheitNr { get; set; }

        public Lagereinheit(string einheitNr)
        {
            EinheitNr = einheitNr;
        }
    }

    public class Rechnungseinheit
    {
        public string EinheitNr { get; set; }

        public Rechnungseinheit(string einheitNr)
        {
            EinheitNr = einheitNr;
        }
    }

    public class Ertragskonto
    {
        public string KontoN { get; set; } = null;

        public Ertragskonto(string KontoNr)
        {
            KontoN = KontoNr;
        }
    }

    public class Steuercode
    {
        public int SteuercodeNr { get; set; }

        public Steuercode(int SteuercodeNr)
        {
            int Steuercode = SteuercodeNr;
        }
    }

    public class DokumentErstellen
    {
        public DokumentErstellen(string dokumentNr, Adresse adresse, string anrede, string datum, Dokumenttyp dokumenttyp, ESRNummer eSRNummer, bool? gedruckt, bool? gesperrt, Region region, Kondition kondition, double? kurs, Land land, Lieferadresse lieferadresse, string lieferadresseAnrede, Lieferart lieferart, string lieferadressEMail, LieferadressRegion lieferadressRegion, LieferadressLand lieferadressLand, string lieferadressName, string lieferadressOrt, string lieferadressPLZ, string lieferadressStrasse, string lieferadressVorname, double? marge, string name, string ort, string pLZ, double? portoFW, double? portoMWStFW, double? portoMWStSW, double? portoSW, string belegdatum, Sammelkonto sammelkonto, double? steuerFW1, double? steuerFW2, double? steuerFW3, double? steuerFW4, double? steuerFW5, Steuercode1 steuercode1, bool? steuerInklusiv1, bool? steuerInklusiv2, bool? steuerInklusiv3, bool? steuerInklusiv4, bool? steuerInklusiv5, bool? steuerMargen1, bool? steuerMargen2, bool? steuerMargen3, bool? steuerMargen4, bool? steuerMargen5, double? steuerSW1, double? steuerSW2, double? steuerSW3, double? steuerSW4, double? steuerSW5, string steuertext1, double? steuertotalFW1, double? steuertotalFW2, double? steuertotalFW3, double? steuertotalFW4, double? steuertotalFW5, double? steuertotalSW1, double? steuertotalSW2, double? steuertotalSW3, double? steuertotalSW4, double? steuertotalSW5, string strasse, double? subtotaldifferenzFW, double? subtotaldifferenzSW, double? totalEinkaufspreisFW, double? totalEinkaufspreisSW, double? totalFW, double? totalgewicht, double? totalsteuerFW, double? totalsteuerSW, double? totalSW, string unserZeichen, Vertreter vertreter, string vorname, IList<string> zahlungen, IList<string> vorauszahlung, Waehrung waehrung, double? zuschlagFW, double? zuschlagMWStFW, double? zuschlagMWStSW, double? zuschlagSW, Sprache sprache, IList<Position> positionen, string erstelltVon, string geaendertVon)
        {
            DokumentNr = dokumentNr;
            Adresse = adresse;
            Anrede = anrede;
            Datum = datum;
            Dokumenttyp = dokumenttyp;
            ESRNummer = eSRNummer;
            Gedruckt = gedruckt;
            Gesperrt = gesperrt;
            Region = region;
            Kondition = kondition;
            Kurs = kurs;
            Land = land;
            Lieferadresse = lieferadresse;
            LieferadresseAnrede = lieferadresseAnrede;
            Lieferart = lieferart;
            LieferadressEMail = lieferadressEMail;
            LieferadressRegion = lieferadressRegion;
            LieferadressLand = lieferadressLand;
            LieferadressName = lieferadressName;
            LieferadressOrt = lieferadressOrt;
            LieferadressPLZ = lieferadressPLZ;
            LieferadressStrasse = lieferadressStrasse;
            LieferadressVorname = lieferadressVorname;
            Marge = marge;
            Name = name;
            Ort = ort;
            PLZ = pLZ;
            PortoFW = portoFW;
            PortoMWStFW = portoMWStFW;
            PortoMWStSW = portoMWStSW;
            PortoSW = portoSW;
            Belegdatum = belegdatum;
            Sammelkonto = sammelkonto;
            SteuerFW1 = steuerFW1;
            SteuerFW2 = steuerFW2;
            SteuerFW3 = steuerFW3;
            SteuerFW4 = steuerFW4;
            SteuerFW5 = steuerFW5;
            Steuercode1 = steuercode1;
            SteuerInklusiv1 = steuerInklusiv1;
            SteuerInklusiv2 = steuerInklusiv2;
            SteuerInklusiv3 = steuerInklusiv3;
            SteuerInklusiv4 = steuerInklusiv4;
            SteuerInklusiv5 = steuerInklusiv5;
            SteuerMargen1 = steuerMargen1;
            SteuerMargen2 = steuerMargen2;
            SteuerMargen3 = steuerMargen3;
            SteuerMargen4 = steuerMargen4;
            SteuerMargen5 = steuerMargen5;
            SteuerSW1 = steuerSW1;
            SteuerSW2 = steuerSW2;
            SteuerSW3 = steuerSW3;
            SteuerSW4 = steuerSW4;
            SteuerSW5 = steuerSW5;
            Steuertext1 = steuertext1;
            SteuertotalFW1 = steuertotalFW1;
            SteuertotalFW2 = steuertotalFW2;
            SteuertotalFW3 = steuertotalFW3;
            SteuertotalFW4 = steuertotalFW4;
            SteuertotalFW5 = steuertotalFW5;
            SteuertotalSW1 = steuertotalSW1;
            SteuertotalSW2 = steuertotalSW2;
            SteuertotalSW3 = steuertotalSW3;
            SteuertotalSW4 = steuertotalSW4;
            SteuertotalSW5 = steuertotalSW5;
            Strasse = strasse;
            SubtotaldifferenzFW = subtotaldifferenzFW;
            SubtotaldifferenzSW = subtotaldifferenzSW;
            TotalEinkaufspreisFW = totalEinkaufspreisFW;
            TotalEinkaufspreisSW = totalEinkaufspreisSW;
            TotalFW = totalFW;
            Totalgewicht = totalgewicht;
            TotalsteuerFW = totalsteuerFW;
            TotalsteuerSW = totalsteuerSW;
            TotalSW = totalSW;
            UnserZeichen = unserZeichen;
            Vertreter = vertreter;
            Vorname = vorname;
            Zahlungen = zahlungen;
            Vorauszahlung = vorauszahlung;
            Waehrung = waehrung;
            ZuschlagFW = zuschlagFW;
            ZuschlagMWStFW = zuschlagMWStFW;
            ZuschlagMWStSW = zuschlagMWStSW;
            ZuschlagSW = zuschlagSW;
            Sprache = sprache;
            Positionen = positionen;
            ErstelltVon = erstelltVon;
            GeaendertVon = geaendertVon;
        }

        public string DokumentNr { get; set; }

        public Adresse Adresse { get; set; }

        public string Anrede { get; set; }

        public string Datum { get; set; }

        public Dokumenttyp Dokumenttyp { get; set; }

        public ESRNummer ESRNummer { get; set; }

        public bool? Gedruckt { get; set; } = false;

        public bool? Gesperrt { get; set; } = false;

        public Region Region { get; set; }

        public Kondition Kondition { get; set; }

        public double? Kurs { get; set; }

        public Land Land { get; set; }

        public Lieferadresse Lieferadresse { get; set; }

        public string LieferadresseAnrede { get; set; }

        public Lieferart Lieferart { get; set; }

        public string LieferadressEMail { get; set; }

        public LieferadressRegion LieferadressRegion { get; set; }

        public LieferadressLand LieferadressLand { get; set; }

        public string LieferadressName { get; set; }

        public string LieferadressOrt { get; set; }

        public string LieferadressPLZ { get; set; }

        public string LieferadressStrasse { get; set; }

        public string LieferadressVorname { get; set; }

        public double? Marge { get; set; }

        public string Name { get; set; }

        public string Ort { get; set; }

        public string PLZ { get; set; }

        public double? PortoFW { get; set; }

        public double? PortoMWStFW { get; set; }

        public double? PortoMWStSW { get; set; }

        public double? PortoSW { get; set; }

        public string Belegdatum { get; set; }

        public Sammelkonto Sammelkonto { get; set; }

        public double? SteuerFW1 { get; set; }
        public double? SteuerFW2 { get; set; }
        public double? SteuerFW3 { get; set; }
        public double? SteuerFW4 { get; set; }
        public double? SteuerFW5 { get; set; }

        public Steuercode1 Steuercode1 { get; set; }

        public bool? SteuerInklusiv1 { get; set; }
        public bool? SteuerInklusiv2 { get; set; }
        public bool? SteuerInklusiv3 { get; set; }
        public bool? SteuerInklusiv4 { get; set; }
        public bool? SteuerInklusiv5 { get; set; }

        public bool? SteuerMargen1 { get; set; }
        public bool? SteuerMargen2 { get; set; }
        public bool? SteuerMargen3 { get; set; }
        public bool? SteuerMargen4 { get; set; }
        public bool? SteuerMargen5 { get; set; }

        public double? SteuerSW1 { get; set; }
        public double? SteuerSW2 { get; set; }
        public double? SteuerSW3 { get; set; }
        public double? SteuerSW4 { get; set; }
        public double? SteuerSW5 { get; set; }

        public string Steuertext1 { get; set; }

        public double? SteuertotalFW1 { get; set; }
        public double? SteuertotalFW2 { get; set; }
        public double? SteuertotalFW3 { get; set; }
        public double? SteuertotalFW4 { get; set; }
        public double? SteuertotalFW5 { get; set; }

        public double? SteuertotalSW1 { get; set; }
        public double? SteuertotalSW2 { get; set; }
        public double? SteuertotalSW3 { get; set; }
        public double? SteuertotalSW4 { get; set; }
        public double? SteuertotalSW5 { get; set; }

        public string Strasse { get; set; }

        public double? SubtotaldifferenzFW { get; set; }

        public double? SubtotaldifferenzSW { get; set; }

        public double? TotalEinkaufspreisFW { get; set; }

        public double? TotalEinkaufspreisSW { get; set; }

        public double? TotalFW { get; set; }

        public double? Totalgewicht { get; set; }

        public double? TotalsteuerFW { get; set; }

        public double? TotalsteuerSW { get; set; }

        public double? TotalSW { get; set; }

        public string UnserZeichen { get; set; }

        public Vertreter Vertreter { get; set; }

        public string Vorname { get; set; }

        public IList<string> Zahlungen { get; set; }

        public IList<string> Vorauszahlung { get; set; }

        public Waehrung Waehrung { get; set; }

        public double? ZuschlagFW { get; set; }

        public double? ZuschlagMWStFW { get; set; }

        public double? ZuschlagMWStSW { get; set; }

        public double? ZuschlagSW { get; set; }

        public Sprache Sprache { get; set; }

        public IList<Position> Positionen { get; set; }

        public string ErstelltVon { get; set; }

        public string GeaendertVon { get; set; }
    }
}
