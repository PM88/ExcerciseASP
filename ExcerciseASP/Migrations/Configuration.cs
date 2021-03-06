﻿namespace ExcerciseASP.Migrations
{
    using System.Data.Entity.Migrations;
    using ExcerciseASP.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ExcerciseASP.DataAccess.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExcerciseASP.DataAccess.ApplicationContext context)
        {
            //Table AddressTypes
            var addressTypes = new List<AddressType>
            {
                new AddressType
                {
                    AddressTypeId = "I",
                    Description = "invoice address"
                },
                new AddressType
                {
                    AddressTypeId = "D",
                    Description = "delivery address"
                },
                new AddressType
                {
                    AddressTypeId = "S",
                    Description = "service address"
                }
            };

            foreach (var type in addressTypes)
                context.AddressTypes.AddOrUpdate(at => at.AddressTypeId, type);


            #region Countries
            //Table countries as per ISO 3166-2 country code
            var countries = new List<Country>
            {
                new Country
                {
                    CountryCode = "I",
                    Name = "invoice address"
                },

                new Country
                {
                    CountryCode = "AD",
                    Name = "Andorra"
                },
                new Country
                {
                    CountryCode = "AE",
                    Name = "United Arab Emirates"
                },
                new Country
                {
                    CountryCode = "AF",
                    Name = "Afghanistan"
                },
                new Country
                {
                    CountryCode = "AG",
                    Name = "Antigua and Barbuda"
                },
                new Country
                {
                    CountryCode = "AI",
                    Name = "Anguilla"
                },
                new Country
                {
                    CountryCode = "AL",
                    Name = "Albania"
                },
                new Country
                {
                    CountryCode = "AM",
                    Name = "Armenia"
                },
                new Country
                {
                    CountryCode = "AO",
                    Name = "Angola"
                },
                new Country
                {
                    CountryCode = "AQ",
                    Name = "Antarctica"
                },
                new Country
                {
                    CountryCode = "AR",
                    Name = "Argentina"
                },
                new Country
                {
                    CountryCode = "AS",
                    Name = "American Samoa"
                },
                new Country
                {
                    CountryCode = "AT",
                    Name = "Austria"
                },
                new Country
                {
                    CountryCode = "AU",
                    Name = "Australia"
                },
                new Country
                {
                    CountryCode = "AW",
                    Name = "Aruba"
                },
                new Country
                {
                    CountryCode = "AX",
                    Name = "Åland Islands"
                },
                new Country
                {
                    CountryCode = "AZ",
                    Name = "Azerbaijan"
                },
                new Country
                {
                    CountryCode = "BA",
                    Name = "Bosnia and Herzegovina"
                },
                new Country
                {
                    CountryCode = "BB",
                    Name = "Barbados"
                },
                new Country
                {
                    CountryCode = "BD",
                    Name = "Bangladesh"
                },
                new Country
                {
                    CountryCode = "BE",
                    Name = "Belgium"
                },
                new Country
                {
                    CountryCode = "BF",
                    Name = "Burkina Faso"
                },
                new Country
                {
                    CountryCode = "BG",
                    Name = "Bulgaria"
                },
                new Country
                {
                    CountryCode = "BH",
                    Name = "Bahrain"
                },
                new Country
                {
                    CountryCode = "BI",
                    Name = "Burundi"
                },
                new Country
                {
                    CountryCode = "BJ",
                    Name = "Benin"
                },
                new Country
                {
                    CountryCode = "BL",
                    Name = "Saint Barthélemy"
                },
                new Country
                {
                    CountryCode = "BM",
                    Name = "Bermuda"
                },
                new Country
                {
                    CountryCode = "BN",
                    Name = "Brunei Darussalam"
                },
                new Country
                {
                    CountryCode = "BO",
                    Name = "Bolivia, Plurinational State of"
                },
                new Country
                {
                    CountryCode = "BQ",
                    Name = "Bonaire, Sint Eustatius and Saba"
                },
                new Country
                {
                    CountryCode = "BR",
                    Name = "Brazil"
                },
                new Country
                {
                    CountryCode = "BS",
                    Name = "Bahamas"
                },
                new Country
                {
                    CountryCode = "BT",
                    Name = "Bhutan"
                },
                new Country
                {
                    CountryCode = "BV",
                    Name = "Bouvet Island"
                },
                new Country
                {
                    CountryCode = "BW",
                    Name = "Botswana"
                },
                new Country
                {
                    CountryCode = "BY",
                    Name = "Belarus"
                },
                new Country
                {
                    CountryCode = "BZ",
                    Name = "Belize"
                },
                new Country
                {
                    CountryCode = "CA",
                    Name = "Canada"
                },
                new Country
                {
                    CountryCode = "CC",
                    Name = "Cocos (Keeling) Islands"
                },
                new Country
                {
                    CountryCode = "CD",
                    Name = "Congo, the Democratic Republic of the"
                },
                new Country
                {
                    CountryCode = "CF",
                    Name = "Central African Republic"
                },
                new Country
                {
                    CountryCode = "CG",
                    Name = "Congo"
                },
                new Country
                {
                    CountryCode = "CH",
                    Name = "Switzerland"
                },
                new Country
                {
                    CountryCode = "CI",
                    Name = "Côte d'Ivoire"
                },
                new Country
                {
                    CountryCode = "CK",
                    Name = "Cook Islands"
                },
                new Country
                {
                    CountryCode = "CL",
                    Name = "Chile"
                },
                new Country
                {
                    CountryCode = "CM",
                    Name = "Cameroon"
                },
                new Country
                {
                    CountryCode = "CN",
                    Name = "China"
                },
                new Country
                {
                    CountryCode = "CO",
                    Name = "Colombia"
                },
                new Country
                {
                    CountryCode = "CR",
                    Name = "Costa Rica"
                },
                new Country
                {
                    CountryCode = "CU",
                    Name = "Cuba"
                },
                new Country
                {
                    CountryCode = "CV",
                    Name = "Cabo Verde"
                },
                new Country
                {
                    CountryCode = "CW",
                    Name = "Curaçao"
                },
                new Country
                {
                    CountryCode = "CX",
                    Name = "Christmas Island"
                },
                new Country
                {
                    CountryCode = "CY",
                    Name = "Cyprus"
                },
                new Country
                {
                    CountryCode = "CZ",
                    Name = "Czechia"
                },
                new Country
                {
                    CountryCode = "DE",
                    Name = "Germany"
                },
                new Country
                {
                    CountryCode = "DJ",
                    Name = "Djibouti"
                },
                new Country
                {
                    CountryCode = "DK",
                    Name = "Denmark"
                },
                new Country
                {
                    CountryCode = "DM",
                    Name = "Dominica"
                },
                new Country
                {
                    CountryCode = "DO",
                    Name = "Dominican Republic"
                },
                new Country
                {
                    CountryCode = "DZ",
                    Name = "Algeria"
                },
                new Country
                {
                    CountryCode = "EC",
                    Name = "Ecuador"
                },
                new Country
                {
                    CountryCode = "EE",
                    Name = "Estonia"
                },
                new Country
                {
                    CountryCode = "EG",
                    Name = "Egypt"
                },
                new Country
                {
                    CountryCode = "EH",
                    Name = "Western Sahara"
                },
                new Country
                {
                    CountryCode = "ER",
                    Name = "Eritrea"
                },
                new Country
                {
                    CountryCode = "ES",
                    Name = "Spain"
                },
                new Country
                {
                    CountryCode = "ET",
                    Name = "Ethiopia"
                },
                new Country
                {
                    CountryCode = "FI",
                    Name = "Finland"
                },
                new Country
                {
                    CountryCode = "FJ",
                    Name = "Fiji"
                },
                new Country
                {
                    CountryCode = "FK",
                    Name = "Falkland Islands (Malvinas)"
                },
                new Country
                {
                    CountryCode = "FM",
                    Name = "Micronesia, Federated States of"
                },
                new Country
                {
                    CountryCode = "FO",
                    Name = "Faroe Islands"
                },
                new Country
                {
                    CountryCode = "FR",
                    Name = "France"
                },
                new Country
                {
                    CountryCode = "GA",
                    Name = "Gabon"
                },
                new Country
                {
                    CountryCode = "GB",
                    Name = "United Kingdom"
                },
                new Country
                {
                    CountryCode = "GD",
                    Name = "Grenada"
                },
                new Country
                {
                    CountryCode = "GE",
                    Name = "Georgia"
                },
                new Country
                {
                    CountryCode = "GF",
                    Name = "French Guiana"
                },
                new Country
                {
                    CountryCode = "GG",
                    Name = "Guernsey"
                },
                new Country
                {
                    CountryCode = "GH",
                    Name = "Ghana"
                },
                new Country
                {
                    CountryCode = "GI",
                    Name = "Gibraltar"
                },
                new Country
                {
                    CountryCode = "GL",
                    Name = "Greenland"
                },
                new Country
                {
                    CountryCode = "GM",
                    Name = "Gambia"
                },
                new Country
                {
                    CountryCode = "GN",
                    Name = "Guinea"
                },
                new Country
                {
                    CountryCode = "GP",
                    Name = "Guadeloupe"
                },
                new Country
                {
                    CountryCode = "GQ",
                    Name = "Equatorial Guinea"
                },
                new Country
                {
                    CountryCode = "GR",
                    Name = "Greece"
                },
                new Country
                {
                    CountryCode = "GS",
                    Name = "South Georgia and the South Sandwich Islands"
                },
                new Country
                {
                    CountryCode = "GT",
                    Name = "Guatemala"
                },
                new Country
                {
                    CountryCode = "GU",
                    Name = "Guam"
                },
                new Country
                {
                    CountryCode = "GW",
                    Name = "Guinea-Bissau"
                },
                new Country
                {
                    CountryCode = "GY",
                    Name = "Guyana"
                },
                new Country
                {
                    CountryCode = "HK",
                    Name = "Hong Kong"
                },
                new Country
                {
                    CountryCode = "HM",
                    Name = "Heard Island and McDonald Islands"
                },
                new Country
                {
                    CountryCode = "HN",
                    Name = "Honduras"
                },
                new Country
                {
                    CountryCode = "HR",
                    Name = "Croatia"
                },
                new Country
                {
                    CountryCode = "HT",
                    Name = "Haiti"
                },
                new Country
                {
                    CountryCode = "HU",
                    Name = "Hungary"
                },
                new Country
                {
                    CountryCode = "ID",
                    Name = "Indonesia"
                },
                new Country
                {
                    CountryCode = "IE",
                    Name = "Ireland"
                },
                new Country
                {
                    CountryCode = "IL",
                    Name = "Israel"
                },
                new Country
                {
                    CountryCode = "IM",
                    Name = "Isle of Man"
                },
                new Country
                {
                    CountryCode = "IN",
                    Name = "India"
                },
                new Country
                {
                    CountryCode = "IO",
                    Name = "British Indian Ocean Territory"
                },
                new Country
                {
                    CountryCode = "IQ",
                    Name = "Iraq"
                },
                new Country
                {
                    CountryCode = "IR",
                    Name = "Iran, Islamic Republic of"
                },
                new Country
                {
                    CountryCode = "IS",
                    Name = "Iceland"
                },
                new Country
                {
                    CountryCode = "IT",
                    Name = "Italy"
                },
                new Country
                {
                    CountryCode = "JE",
                    Name = "Jersey"
                },
                new Country
                {
                    CountryCode = "JM",
                    Name = "Jamaica"
                },
                new Country
                {
                    CountryCode = "JO",
                    Name = "Jordan"
                },
                new Country
                {
                    CountryCode = "JP",
                    Name = "Japan"
                },
                new Country
                {
                    CountryCode = "KE",
                    Name = "Kenya"
                },
                new Country
                {
                    CountryCode = "KG",
                    Name = "Kyrgyzstan"
                },
                new Country
                {
                    CountryCode = "KH",
                    Name = "Cambodia"
                },
                new Country
                {
                    CountryCode = "KI",
                    Name = "Kiribati"
                },
                new Country
                {
                    CountryCode = "KM",
                    Name = "Comoros"
                },
                new Country
                {
                    CountryCode = "KN",
                    Name = "Saint Kitts and Nevis"
                },
                new Country
                {
                    CountryCode = "KP",
                    Name = "Korea (the Democratic People's Republic of)"
                },
                new Country
                {
                    CountryCode = "KR",
                    Name = "Korea (the Republic of)"
                },
                new Country
                {
                    CountryCode = "KW",
                    Name = "Kuwait"
                },
                new Country
                {
                    CountryCode = "KY",
                    Name = "Cayman Islands"
                },
                new Country
                {
                    CountryCode = "KZ",
                    Name = "Kazakhstan"
                },
                new Country
                {
                    CountryCode = "LA",
                    Name = "Lao People's Democratic Republic"
                },
                new Country
                {
                    CountryCode = "LB",
                    Name = "Lebanon"
                },
                new Country
                {
                    CountryCode = "LC",
                    Name = "Saint Lucia"
                },
                new Country
                {
                    CountryCode = "LI",
                    Name = "Liechtenstein"
                },
                new Country
                {
                    CountryCode = "LK",
                    Name = "Sri Lanka"
                },
                new Country
                {
                    CountryCode = "LR",
                    Name = "Liberia"
                },
                new Country
                {
                    CountryCode = "LS",
                    Name = "Lesotho"
                },
                new Country
                {
                    CountryCode = "LT",
                    Name = "Lithuania"
                },
                new Country
                {
                    CountryCode = "LU",
                    Name = "Luxembourg"
                },
                new Country
                {
                    CountryCode = "LV",
                    Name = "Latvia"
                },
                new Country
                {
                    CountryCode = "LY",
                    Name = "Libya"
                },
                new Country
                {
                    CountryCode = "MA",
                    Name = "Morocco"
                },
                new Country
                {
                    CountryCode = "MC",
                    Name = "Monaco"
                },
                new Country
                {
                    CountryCode = "MD",
                    Name = "Moldova, Republic of"
                },
                new Country
                {
                    CountryCode = "ME",
                    Name = "Montenegro"
                },
                new Country
                {
                    CountryCode = "MF",
                    Name = "Saint Martin (French part)"
                },
                new Country
                {
                    CountryCode = "MG",
                    Name = "Madagascar"
                },
                new Country
                {
                    CountryCode = "MH",
                    Name = "Marshall Islands"
                },
                new Country
                {
                    CountryCode = "MK",
                    Name = "Macedonia, the former Yugoslav Republic of"
                },
                new Country
                {
                    CountryCode = "ML",
                    Name = "Mali"
                },
                new Country
                {
                    CountryCode = "MM",
                    Name = "Myanmar"
                },
                new Country
                {
                    CountryCode = "MN",
                    Name = "Mongolia"
                },
                new Country
                {
                    CountryCode = "MO",
                    Name = "Macao"
                },
                new Country
                {
                    CountryCode = "MP",
                    Name = "Northern Mariana Islands"
                },
                new Country
                {
                    CountryCode = "MQ",
                    Name = "Martinique"
                },
                new Country
                {
                    CountryCode = "MR",
                    Name = "Mauritania"
                },
                new Country
                {
                    CountryCode = "MS",
                    Name = "Montserrat"
                },
                new Country
                {
                    CountryCode = "MT",
                    Name = "Malta"
                },
                new Country
                {
                    CountryCode = "MU",
                    Name = "Mauritius"
                },
                new Country
                {
                    CountryCode = "MV",
                    Name = "Maldives"
                },
                new Country
                {
                    CountryCode = "MW",
                    Name = "Malawi"
                },
                new Country
                {
                    CountryCode = "MX",
                    Name = "Mexico"
                },
                new Country
                {
                    CountryCode = "MY",
                    Name = "Malaysia"
                },
                new Country
                {
                    CountryCode = "MZ",
                    Name = "Mozambique"
                },
                new Country
                {
                    CountryCode = "NA",
                    Name = "Namibia"
                },
                new Country
                {
                    CountryCode = "NC",
                    Name = "New Caledonia"
                },
                new Country
                {
                    CountryCode = "NE",
                    Name = "Niger"
                },
                new Country
                {
                    CountryCode = "NF",
                    Name = "Norfolk Island"
                },
                new Country
                {
                    CountryCode = "NG",
                    Name = "Nigeria"
                },
                new Country
                {
                    CountryCode = "NI",
                    Name = "Nicaragua"
                },
                new Country
                {
                    CountryCode = "NL",
                    Name = "Netherlands[note 1]"
                },
                new Country
                {
                    CountryCode = "NO",
                    Name = "Norway"
                },
                new Country
                {
                    CountryCode = "NP",
                    Name = "Nepal"
                },
                new Country
                {
                    CountryCode = "NR",
                    Name = "Nauru"
                },
                new Country
                {
                    CountryCode = "NU",
                    Name = "Niue"
                },
                new Country
                {
                    CountryCode = "NZ",
                    Name = "New Zealand"
                },
                new Country
                {
                    CountryCode = "OM",
                    Name = "Oman"
                },
                new Country
                {
                    CountryCode = "PA",
                    Name = "Panama"
                },
                new Country
                {
                    CountryCode = "PE",
                    Name = "Peru"
                },
                new Country
                {
                    CountryCode = "PF",
                    Name = "French Polynesia"
                },
                new Country
                {
                    CountryCode = "PG",
                    Name = "Papua New Guinea"
                },
                new Country
                {
                    CountryCode = "PH",
                    Name = "Philippines"
                },
                new Country
                {
                    CountryCode = "PK",
                    Name = "Pakistan"
                },
                new Country
                {
                    CountryCode = "PL",
                    Name = "Poland"
                },
                new Country
                {
                    CountryCode = "PM",
                    Name = "Saint Pierre and Miquelon"
                },
                new Country
                {
                    CountryCode = "PN",
                    Name = "Pitcairn"
                },
                new Country
                {
                    CountryCode = "PR",
                    Name = "Puerto Rico"
                },
                new Country
                {
                    CountryCode = "PS",
                    Name = "Palestine, State of"
                },
                new Country
                {
                    CountryCode = "PT",
                    Name = "Portugal"
                },
                new Country
                {
                    CountryCode = "PW",
                    Name = "Palau"
                },
                new Country
                {
                    CountryCode = "PY",
                    Name = "Paraguay"
                },
                new Country
                {
                    CountryCode = "QA",
                    Name = "Qatar"
                },
                new Country
                {
                    CountryCode = "RE",
                    Name = "Réunion"
                },
                new Country
                {
                    CountryCode = "RO",
                    Name = "Romania"
                },
                new Country
                {
                    CountryCode = "RS",
                    Name = "Serbia"
                },
                new Country
                {
                    CountryCode = "RU",
                    Name = "Russian Federation"
                },
                new Country
                {
                    CountryCode = "RW",
                    Name = "Rwanda"
                },
                new Country
                {
                    CountryCode = "SA",
                    Name = "Saudi Arabia"
                },
                new Country
                {
                    CountryCode = "SB",
                    Name = "Solomon Islands"
                },
                new Country
                {
                    CountryCode = "SC",
                    Name = "Seychelles"
                },
                new Country
                {
                    CountryCode = "SD",
                    Name = "Sudan"
                },
                new Country
                {
                    CountryCode = "SE",
                    Name = "Sweden"
                },
                new Country
                {
                    CountryCode = "SG",
                    Name = "Singapore"
                },
                new Country
                {
                    CountryCode = "SH",
                    Name = "Saint Helena, Ascension and Tristan da Cunha"
                },
                new Country
                {
                    CountryCode = "SI",
                    Name = "Slovenia"
                },
                new Country
                {
                    CountryCode = "SJ",
                    Name = "Svalbard and Jan Mayen"
                },
                new Country
                {
                    CountryCode = "SK",
                    Name = "Slovakia"
                },
                new Country
                {
                    CountryCode = "SL",
                    Name = "Sierra Leone"
                },
                new Country
                {
                    CountryCode = "SM",
                    Name = "San Marino"
                },
                new Country
                {
                    CountryCode = "SN",
                    Name = "Senegal"
                },
                new Country
                {
                    CountryCode = "SO",
                    Name = "Somalia"
                },
                new Country
                {
                    CountryCode = "SR",
                    Name = "Suriname"
                },
                new Country
                {
                    CountryCode = "SS",
                    Name = "South Sudan"
                },
                new Country
                {
                    CountryCode = "ST",
                    Name = "Sao Tome and Principe"
                },
                new Country
                {
                    CountryCode = "SV",
                    Name = "El Salvador"
                },
                new Country
                {
                    CountryCode = "SX",
                    Name = "Sint Maarten (Dutch part)"
                },
                new Country
                {
                    CountryCode = "SY",
                    Name = "Syrian Arab Republic"
                },
                new Country
                {
                    CountryCode = "SZ",
                    Name = "Swaziland"
                },
                new Country
                {
                    CountryCode = "TC",
                    Name = "Turks and Caicos Islands"
                },
                new Country
                {
                    CountryCode = "TD",
                    Name = "Chad"
                },
                new Country
                {
                    CountryCode = "TF",
                    Name = "French Southern Territories"
                },
                new Country
                {
                    CountryCode = "TG",
                    Name = "Togo"
                },
                new Country
                {
                    CountryCode = "TH",
                    Name = "Thailand"
                },
                new Country
                {
                    CountryCode = "TJ",
                    Name = "Tajikistan"
                },
                new Country
                {
                    CountryCode = "TK",
                    Name = "Tokelau"
                },
                new Country
                {
                    CountryCode = "TL",
                    Name = "Timor-Leste"
                },
                new Country
                {
                    CountryCode = "TM",
                    Name = "Turkmenistan"
                },
                new Country
                {
                    CountryCode = "TN",
                    Name = "Tunisia"
                },
                new Country
                {
                    CountryCode = "TO",
                    Name = "Tonga"
                },
                new Country
                {
                    CountryCode = "TR",
                    Name = "Turkey"
                },
                new Country
                {
                    CountryCode = "TT",
                    Name = "Trinidad and Tobago"
                },
                new Country
                {
                    CountryCode = "TV",
                    Name = "Tuvalu"
                },
                new Country
                {
                    CountryCode = "TW",
                    Name = "Taiwan, Province of China [note 2]"
                },
                new Country
                {
                    CountryCode = "TZ",
                    Name = "Tanzania, United Republic of"
                },
                new Country
                {
                    CountryCode = "UA",
                    Name = "Ukraine"
                },
                new Country
                {
                    CountryCode = "UG",
                    Name = "Uganda"
                },
                new Country
                {
                    CountryCode = "UM",
                    Name = "United States Minor Outlying Islands"
                },
                new Country
                {
                    CountryCode = "US",
                    Name = "United States"
                },
                new Country
                {
                    CountryCode = "UY",
                    Name = "Uruguay"
                },
                new Country
                {
                    CountryCode = "UZ",
                    Name = "Uzbekistan"
                },
                new Country
                {
                    CountryCode = "VA",
                    Name = "Holy See (Vatican City State)"
                },
                new Country
                {
                    CountryCode = "VC",
                    Name = "Saint Vincent and the Grenadines"
                },
                new Country
                {
                    CountryCode = "VE",
                    Name = "Venezuela, Bolivarian Republic of"
                },
                new Country
                {
                    CountryCode = "VG",
                    Name = "Virgin Islands, British"
                },
                new Country
                {
                    CountryCode = "VI",
                    Name = "Virgin Islands, U.S."
                },
                new Country
                {
                    CountryCode = "VN",
                    Name = "Viet Nam"
                },
                new Country
                {
                    CountryCode = "VU",
                    Name = "Vanuatu"
                },
                new Country
                {
                    CountryCode = "WF",
                    Name = "Wallis and Futuna"
                },
                new Country
                {
                    CountryCode = "WS",
                    Name = "Samoa"
                },
                new Country
                {
                    CountryCode = "YE",
                    Name = "Yemen"
                },
                new Country
                {
                    CountryCode = "YT",
                    Name = "Mayotte"
                },
                new Country
                {
                    CountryCode = "ZA",
                    Name = "South Africa"
                },
                new Country
                {
                    CountryCode = "ZM",
                    Name = "Zambia"
                },
                new Country
                {
                    CountryCode = "ZW",
                    Name = "Zimbabwe"
                }
            };

            foreach (var country in countries)
                context.Countries.AddOrUpdate(a => a.CountryCode, country);
            #endregion


            //Test data for Customer table
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = "Cust1",
                    Name = "John Smith"
                },
                new Customer
                {
                    CustomerId = "Cust2",
                    Name = "Anna Smith"
                },
                new Customer
                {
                    CustomerId = "Cust3",
                    Name = "Stefan Doe"
                }
            };
            foreach (var customer in customers)
                context.Customers.AddOrUpdate(c => new { c.CustomerId, c.Name }, customer);


            //Test data for Address table
            var addresses = new List<Address>
            {
                new Address
                {
                    CustomerId = "Cust1",
                    AddressTypeId =  "I",
                    Name = "John Smith",
                    Street = "Long St.",
                    ZIP = "20-234",
                    City = "London",
                    CountryCode = "GB"
                },
                new Address
                {
                    CustomerId = "Cust2",
                    AddressTypeId =  "D",
                    Name = "Anna Smith",
                    Street = "Far Ave.",
                    ZIP = "30-345",
                    City = "Wrocław",
                    CountryCode = "PL"
                },
                new Address
                {
                    CustomerId = "Cust3",
                    AddressTypeId =  "S",
                    Name = "Stefan Doe",
                    Street = "Corner St.",
                    ZIP = "40-456",
                    City = "Köln",
                    CountryCode = "DE"
                }
            };

            foreach (var address in addresses)
                context.Addresses.AddOrUpdate(a => new { a.CustomerId, a.AddressTypeId }, address);
        }
    }
}
