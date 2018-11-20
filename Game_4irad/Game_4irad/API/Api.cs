using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirApi
{
    /**
     * End Points implemented:
     * [X] /game/[game_id]
     * [/] /game/[game_id]/grid
     * [X] /game/[game_id]/pawns
     * [X] /player/[player_id]
     * [X] /player/[player_id]/games
     * [X] /player/auth
     * [/] /player/add
     * [/] /whoami
     * [/] /whoami/game
     * [/] /game/add
     * [/] /play/[game_id]/[x]/[y]
     */
    public class Api
    {
        #region Url
        string api_url;
        public Api()
        {
            api_url = "https://fir.tuffsruffs.se/api/";
        }
        public Api(string url)
        {
            api_url = url;
        }
        #endregion

        #region /game/<id>
        public async Task<string> gameRaw(int game_id)
        {
            String url = api_url + "game/" + game_id;
            var ajax = new System.Net.Http.HttpClient();
            return await ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
        }

        public async Task<Game> game(int game_id)
        {
            Game game = Newtonsoft.Json.JsonConvert.DeserializeObject<Game>(await this.gameRaw(game_id));
            if (game.Game_ID == 0) throw new NoResultException();
            return game;
        }
        #endregion

        #region /player/<id>
        public async Task<string> playerRaw(int player_id)
        {
            String url = api_url + "player/" + player_id;
            var ajax = new System.Net.Http.HttpClient();
            return await ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
        }

        public async Task<Player> player(int player_id)
        {
            Player player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(await this.playerRaw(player_id));
            if (player.Player_ID == 0) throw new NoResultException();
            return player;
        }
        #endregion

        #region /game/<id>/pawns
        public async Task<string> pawnsRaw(int game_id)
        {
            String url = api_url + "game/" + game_id + "/pawns";
            var ajax = new System.Net.Http.HttpClient();
            return await ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
        }

        public async Task<List<Pawn>> pawns(int game_id)
        {
            List<Pawn> pawns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pawn>>(await this.pawnsRaw(game_id));
            if (pawns.Count == 0) throw new NoResultException();
            return pawns;
        }
        #endregion

        #region /player/<id>/games
        public async Task<string> gamesRaw(int player_id)
        {
            String url = api_url + "player/" + player_id + "/games";
            var ajax = new System.Net.Http.HttpClient();
            return await ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
        }

        public async Task<List<Game>> games(int player_id)
        {
            List<Game> games = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Game>>(await this.gamesRaw(player_id));
            if (games.Count == 0) throw new NoResultException();
            return games;
        }
        #endregion

        #region /player/auth
        public async Task<string> authRaw(string user_name)
        {
            String url = api_url + "player/auth";
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("username", user_name));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url,post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<PlayerToken> auth(string user_name)
        {
            PlayerToken token = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerToken>(await this.authRaw(user_name));
            if (token.Token == null) throw new NoResultException();
            return token;
        }
        #endregion

        #region /player/add
        public async Task<string> joinRaw(string user_name)
        {
            String url = api_url + "player/add";
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("username", user_name));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url, post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<PlayerToken> join(string user_name)
        {
            PlayerToken token = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerToken>(await this.authRaw(user_name));
            if (token.Player_ID == 0) throw new NoResultException();
            return token;
        }
        #endregion

        #region /whoami
        public async Task<string> whoRaw(string token)
        {
            String url = api_url + "whoami";
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("token", token));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url, post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<Player> who(string token)
        {
            Player player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(await this.whoRaw(token));
            if (player.Player_ID == 0) throw new NoResultException();
            return player;
        }
        #endregion

        #region /whoami/game
        public async Task<string> myGameRaw(string token)
        {
            String url = api_url + "whoami/game";
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("token", token));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url, post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<Game> myGame(string token)
        {
            Game game = Newtonsoft.Json.JsonConvert.DeserializeObject<Game>(await this.myGameRaw(token));
            if (game.Game_ID == 0) throw new NoResultException();
            return game;
        }
        #endregion

        #region /game/add
        public async Task<string> startGameRaw(string token, string opponent)
        {
            String url = api_url + "game/add";
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("token", token));
            post_data_list.Add(new KeyValuePair<string, string>("opponent", opponent));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url, post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<Game> startGame(string token, string opponent)
        {
            Game game = Newtonsoft.Json.JsonConvert.DeserializeObject<Game>(await this.startGameRaw(token, opponent));
            if (game.Game_ID == 0) throw new NoResultException();
            return game;
        }
        #endregion

        #region /play/<game_id>/<x>/<y>
        public async Task<string> playRaw(string token, int game_id, int x, int y)
        {
            String url = api_url + "play/" + game_id + "/" + x + "/" + y;
            var ajax = new System.Net.Http.HttpClient();
            var post_data_list = new List<KeyValuePair<string, string>>();
            post_data_list.Add(new KeyValuePair<string, string>("token", token));
            var post_data = new System.Net.Http.FormUrlEncodedContent(post_data_list);
            return await ajax.PostAsync(url, post_data).Result.Content.ReadAsStringAsync();
        }

        public async Task<Game> play(string token, int game_id, int x, int y)
        {
            Game game = Newtonsoft.Json.JsonConvert.DeserializeObject<Game>(await this.playRaw(token, game_id, x, y));
            if (game.Game_ID == 0) throw new NoResultException();
            return game;
        }
        #endregion

        #region /game/<id>/grid
        public async Task<string> gridRaw(int game_id)
        {
            String url = api_url + "game/" + game_id + "/grid";
            var ajax = new System.Net.Http.HttpClient();
            return await ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
        }

        public async Task<List<List<int>>> grid(int game_id)
        {
            List<List<int>> grid = Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<int>>>(await this.gridRaw(game_id));
            if (grid.Count == 0) throw new NoResultException();
            return grid;
        }
        #endregion
    }
}
