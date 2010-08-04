using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaNGOS_GUI.DataAccess
{
    class ServerData
    {        
        public bool checkAccountExists(string accountName)
        {
            bool accountCheck = true;
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "SELECT * FROM account WHERE username = '" + accountName + "'";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    accountCheck = true;
                }
                else
                {
                    accountCheck = false;
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB );
            }
            finally
            {
                conn.Close();
            }

            return accountCheck;
        }

        public bool checkCharacterExists(string characterName)
        {
            bool characterCheck = true;
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT * FROM characters WHERE name = '" + characterName + "'";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    characterCheck = true;
                }
                else
                {
                    characterCheck = false;
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return characterCheck;
        }

        public int checkCurrentPopulation()
        {
            int p = 0;
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "SELECT COUNT(*) FROM account WHERE active_realm_id = '1'";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            try
            {
                conn.Open();
                p = Convert.ToInt16(cmd.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }
            
            return p;
        }

        public IList<string> getTeleportLocations()
        {
            string connectString = ServerConnectStrings.mangosConnectString();
            string cmdString = "SELECT name FROM game_tele";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            IList<string> locations = new List<string>();

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    locations.Add(reader["name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return locations;
        }

        public IList<string> getCharacters()
        {
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT name FROM characters ORDER BY NAME";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            IList<string> characters = new List<string>();

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    characters.Add(reader["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return characters;
        }

        public IList<string> getAccounts()
        {
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "select 	username from  account order by username";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);

            IList<string> Accounts = new List<string>();

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Accounts.Add(reader["username"].ToString());
                }
            }
            catch
            {
               MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return Accounts;
        }

        public DataTable getBans()
        {
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "SELECT account.username, CAST(FROM_UNIXTIME(account_banned.bandate) AS CHAR) AS bandate, " + 
                               "CAST(IF(account_banned.unbandate = account_banned.bandate, 'permanent', " +
                               "FROM_UNIXTIME(account_banned.unbandate)) AS CHAR) AS unbandate, account_banned.bannedby, " +
                               "account_banned.banreason  FROM account " +
                               "INNER JOIN account_banned ON account.id = account_banned.id " +
                               "WHERE account_banned.active >= '1'";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable bans = new DataTable("Bans");

            try
            {
                conn.Open();
                adapter.Fill(bans);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return bans;
        }

        public DataTable getGM()
        {
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "SELECT username, gmlevel FROM account WHERE gmlevel >= '2'";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable gmList = new DataTable("Bans");

            try
            {
                conn.Open();
                adapter.Fill(gmList);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return gmList;
        }

        public DataTable getOnlineData()
        {
            string connectString = ServerConnectStrings.realmConnectString();
            string cmdString = "SELECT realmd.account.username AS Account, " +
                               "characters.characters.name AS 'Character', realmd.account.last_ip AS IP, " +
                               "realmd.account.gmlevel AS GM, realmd.account.expansion AS TBC FROM realmd.account " +
                               "INNER JOIN characters.characters ON " +
                               "realmd.account.id = characters.characters.account WHERE " +
                               "characters.characters.online = 1;";

            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable onlineList = new DataTable("Online");

            try
            {
                conn.Open();
                adapter.Fill(onlineList);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return onlineList;

        }

        public DataTable getTickets()
        {
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT ticket_id, guid, ticket_text, response_text FROM characters.character_ticket;";
            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Tickets = new DataTable("Tickets");

            try
            {
                conn.Open();
                adapter.Fill(Tickets);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return Tickets;

        }

        // Грузим из БД список аккаунтов
        public DataTable getAccountList()
        {
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT id, username, gmlevel, joindate, last_ip, active_realm_id, expansion FROM realmd.account;";
            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Accounts = new DataTable("Accounts");

            try
            {
                conn.Open();
                adapter.Fill(Accounts);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return Accounts;
        }

        // Грузим из БД список персонажей
        public DataTable getCharacterList()
        {
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT guid, account, name, level, money, online FROM characters.characters;";
            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Characters = new DataTable("Characters");

            try
            {
                conn.Open();
                adapter.Fill(Characters);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return Characters;
        }

        public DataTable getItems()
        {
            string connectString = ServerConnectStrings.charConnectString();
            string cmdString = "SELECT entry, class, name FROM mangos.item_template;";
            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Items = new DataTable("Items");

            try
            {
                conn.Open();
                adapter.Fill(Items);
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_ErrorConnectingDB);
            }
            finally
            {
                conn.Close();
            }

            return Items;
        }
    }
}
