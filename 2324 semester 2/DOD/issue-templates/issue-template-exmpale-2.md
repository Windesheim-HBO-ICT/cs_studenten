### Beschrijving
Er was eens...

#### Acceptatie criteria
- [ ] foo
- [ ] bar

## Testen

### Integratie testen (Cypress)
- [ ] foo
- [ ] bar


<details><summary>Definition of done (click to expand)</summary>

## Definition of Done

### Globaal
- [ ] ESLint geeft geen fouten;
- [ ] Code in het Engels; (eventueel Nederlands bij formele begrippen)
- [ ] Code voorzien van commentaar, waar noodzakelijk.
- [ ] Camelcasing, startend met een kleine letter. Geldt ook voor bestandsnamen. Alleen classes beginnen met een hoofdletter.
- [ ] Errorhandling is toegepast op basis van error-helpers en de beschrijving hiervan op de wiki: [Try catch error handling](https://gitlab.com/teamlynn/tasker/wikis/Architectuur/Error-handling).
- [ ] Er is **geen console.log aanwezig**, alleen de centrale [logging](https://gitlab.com/teamlynn/tasker/wikis/Architectuur/Logging).

### Configuratie en environment
- [ ] Configuratie parameters zijn opgehaald via `config.get().<parameter>`
- [ ] Voor het raadplegen in welke modus de applicatie draait is gebruik gemaakt van de `environmentService`.
- [ ] **Nieuwe** configuratie parameters zijn toegevoegd aan `configSchema` en eventueel aan `/tooling/local-setup.js`.

### Models
- [ ] Als een model een nieuw veld/property heeft gekregen dan: **is deze in de relevante seeds meegenomen /seeders/....**
- [ ] De tiers (repository, services en routes) zijn gecontroleerd of het veld toegevoegd moet worden (bijvoorbeeld bij een create operatie).
- [ ] Als een nieuw model is toegevoegd dan: **heeft dit model een bijbehorende repository en bijbehorende service.**
- [ ] Voor relaties gelden twee regels
<br> 1) geneste data heeft ook een referentie naar de root (project > task > taskresult, deze laatste heeft naar task en project een ref) <br> 2) relaties worden in principe vastgelegd met een object ref, alleen als de data niet verder genest wordt en de data wordt alleen embedded geraadpleegd dan is het toegestaan om de data geembed op te slaan, en het gaat om weinig data.

### Tiers
- [ ] Services zijn niet beschikbaar in repositories
- [ ] Repositories zijn **alleen** beschikbaar in services
- [ ] Als een service is gebruikt als middleware dan is dit opgenomen in de naam, bijvoorbeeld: `authorizationMiddlewareService`.
- [ ] Een nieuwe route heeft authorisatie ontvangen, gebruikmakend van de [authorizationMiddlewareService](https://gitlab.com/teamlynn/tasker/wikis/Architectuur/Authorisation)
- [ ] Om circular dependencies te voorkomen wordt content in services (episodeService, levelService etc.) alleen richting children opgehaald. Parent data is meegegeven.

### Testen
Zie de [Cypress best practises](https://docs.cypress.io/guides/references/best-practices) voor meer informatie over de onderstaande criteria en hoe je ze waarborgt.

#### Permissions
Indien van toepassing, zorg ervoor dat de testen uitgevoerd worden met alle onderstaande permissions/scenario's.
| Scenario's  |
|-------------|
| <span dir="">student niet verbonden aan project </span> |
| <span dir="">student verbonden aan project </span> |
| <span dir="">docent is project eigenaar</span> |
| <span dir="">docent niet verbonden aan project </span> |
| <span dir="">docent verbonden aan project zonder permissie</span> |
| <span dir="">docent verbonden aan project met permissie</span> |

##### Algemeen
- [ ] Testen zijn geschreven volgens de [Cypress conventies](https://docs.cypress.io/guides/references/best-practices)
- [ ] specs ([naam].cy.ts) zijn per pagina opgesteld en dekken alle functionaliteit van die pagina.
- [ ] Testen zijn '[flake-free](https://www.jetbrains.com/teamcity/ci-cd-guide/concepts/flaky-tests/)' . Run de testen dus niet slechts 1x lokaal voor je het commit, maar meerdere malen.
- [ ] Er is geen statische text getest(hardcoded text dat niet veranderd, zoals een titel van een dialoog), de testen beperken zich tot dynamische content.
- [ ] Commands zijn alleen gemaakt voor herhalende code over meerdere specs. Als code alleen binnen één spec voorkomt, kan daar een normale functie voor komen.
- [ ] Alle testen slagen in de pipeline.
- [ ] Testperformance is optimaal. Geen onnodige [waits](https://docs.cypress.io/api/commands/wait) en (trage) UI-handelingen die programmatisch kunnen.
- [ ] Handelingen worden alleen via de UI uitgevoerd wanneer de test die specifieke handeling test. Anders kan dit programmatisch. 
- [ ] Url's zijn getest op pathname en responsecode(dat de url correct is, betekent niet dat de pagina goed ingeladen is). Hier is een custom command voor.
- [ ] Maak gebruik van [cy.context](https://docs.cypress.io/guides/core-concepts/writing-and-organizing-tests#Test%20Structure) om testen te categoriseren. onderscheid hiermee de gebruikersrol, de permissions, het soort handelingen, etc.

##### Fixtures
- [ ] Bestaande fixtures zijn niet aangepast als ze in gebruik zijn door andere tests
- [ ] Fixtures hebben beschrijvende namen, BV: projectWithStudentsAndCollaborators.
- [ ] Na het aanmaken van nieuwe fixtures is de config aangevuld (config.ts & config.json)

##### Permissions
- [ ] Elke functionaliteit wordt getest met alle relevante permissions. De permissions staan in _permissions.json_. Bijvoorbeeld CRUD functionaliteit wordt getest voor de eigenaar en collaborators met verschillende permissions.

##### Data-cy
- [ ] Voor het aanspreken van html-elementen zijn enkel en alleen data-cy attributen gebruikt.
- [ ] Data-cy attributen zijn in kebab-case en zonder hoofdletters.
- [ ] Entiteit-specifieke parameters (zoals id of naam) zijn top-level toegevoegd(bijvoorbeeld aan een overkoepelende Div of een Tr). 
- [ ] Data-cy attributen met Entiteit-specifieke parameters zijn volgens dit format: [parameter]-[omschrijving(optioneel)]   BV: "Reversi-row"
- [ ] Child elementen hebben generieke namen, zoals: 'edit-project' of 'delete-episode'.
- [ ] Query elementen alleen met data-cy, probeer het elementtype weg te laten, dus niet: ‘**a**[data-cy=”new-project”]’, maar: ‘[data-cy=”new-project”]’ 

</details>
</details>
