'Module pour les variable partagées sur tout le logiciel
Module modShare
    Public GlobalUserType As String
    Public GlobalUserID As String
    Public GlobalUserName As String
    Public GlobalServices As String
    'Table Clefs
    Public strTitleCID As String = "N° de Clef"
    Public strTitleCNom As String = "Accès"
    Public strTitleCPosition As String = "Tableau"
    Public strTitleCStatus As String = "Status"
    Public strTitleCDate As String = "Date"
    Public strTitleCTrousseau As String = "Trousseau"
    Public strTitleCBatiment As String = "Bâtiment"
    'Table Emprunts
    Public strTitleEIDClef As String = "N° de Clef"
    Public strTitleENomPersonne As String = "Nom"
    Public strTitleEDateDebut As String = "Date d'emprunt"
    Public strTitleEDateFin As String = "Date de retour"
    Public strTitleEGenre As String = "Fonction"
    'Table Batiment
    Public strTitleBNum As String = "N°"
    Public strTitleBNom As String = "Dénomination"
    Public strTitleBAdresse As String = "Adresse"
    Public strTitleBFonction As String = "Fonction"
    'Table NomPersonne
    Public strTitleNNom As String = "Nom"
    Public strTitleNGenre As String = "Fonction"
    Public strTitleNTelephone As String = "Téléphone"
    Public strTitleNAutre As String = "Compléments"
    'Table Genre
    Public strTitleGGenre As String = "Fonction"
    'Table Position
    Public strTitlePNom As String = "Nom"
    Public strTitlePResponsable As String = "Responsable"
    Public strTitlePBatiment As String = "Bâtiment"
    'Table Trousseau
    Public strTitleTNom As String = "Nom"
    Public strTitleTPersonne As String = "Détenteur"
    'Table GroupeBat
    Public strTitleGIDBat As String = "Bâtiment"

End Module
