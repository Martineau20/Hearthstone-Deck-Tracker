﻿#region

using Hearthstone_Deck_Tracker.Enums;
using Hearthstone_Deck_Tracker.Hearthstone;

#endregion

namespace Hearthstone_Deck_Tracker.API
{
	public class GameEvents
	{
		#region Player

		public static readonly ActionList<Card> OnPlayerDraw = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerGet = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerPlay = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerHandDiscard = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerMulligan = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerDeckDiscard = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerPlayToDeck = new ActionList<Card>();
		public static readonly ActionList<Card> OnPlayerPlayToHand = new ActionList<Card>();
		public static readonly ActionList OnPlayerHeroPower = new ActionList();
		public static readonly ActionList<int> OnPlayerFatigue = new ActionList<int>();

		#endregion

		#region Opponent

		public static readonly ActionList OnOpponentDraw = new ActionList();
		public static readonly ActionList OnOpponentGet = new ActionList();
		public static readonly ActionList<Card> OnOpponentPlay = new ActionList<Card>();
		public static readonly ActionList<Card> OnOpponentHandDiscard = new ActionList<Card>();
		public static readonly ActionList OnOpponentMulligan = new ActionList();
		public static readonly ActionList<Card> OnOpponentDeckDiscard = new ActionList<Card>();
		public static readonly ActionList<Card> OnOpponentPlayToDeck = new ActionList<Card>();
		public static readonly ActionList<Card> OnOpponentPlayToHand = new ActionList<Card>();
		public static readonly ActionList<Card> OnOpponentSecretTriggered = new ActionList<Card>();
		public static readonly ActionList OnOpponentHeroPower = new ActionList();
		public static readonly ActionList<int> OnOpponentFatigue = new ActionList<int>();

		#endregion

		#region Game

		public static readonly ActionList OnGameStart = new ActionList();
		public static readonly ActionList OnGameEnd = new ActionList();
		public static readonly ActionList OnGameWon = new ActionList();
		public static readonly ActionList OnGameLost = new ActionList();
		public static readonly ActionList OnGameTied = new ActionList();
		public static readonly ActionList OnInMenu = new ActionList();
		public static readonly ActionList<ActivePlayer> OnTurnStart = new ActionList<ActivePlayer>();

		#endregion
	}
}