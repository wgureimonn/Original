using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// A-star algorithm
public class AStar : MonoBehaviour {

	struct Point2 {
		public int x;
		public int y;
		public Point2(int x=0, int y=0) {
			this.x = x;
			this.y = y;
		}

		public void Set(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}

	/// A-starノード.
	class ANode {
		enum eStatus {
			None,
			Open,
			Closed,
		}
		/// ステータス
		eStatus _status = eStatus.None;
		/// 実コスト
		int _cost = 0;
		/// ヒューリスティック・コスト
		int _heuristic = 0;
		/// 親ノード
		ANode _parent = null;
		/// 座標
		int _x = 0;
		int _y = 0;
		public int X {
			get { return _x; }
		}
		public int Y {
			get { return _y; }
		}
		public int Cost {
			get { return _cost; }
		}

		/// コンストラクタ.
		public ANode(int x, int y) {
			_x = x;
			_y = y;
		}
		/// スコアを計算する.
		public int GetScore() {
			return _cost + _heuristic;
		}
		/// ヒューリスティック・コストの計算.
		public void CalcHeuristic(bool allowdiag, int xgoal, int ygoal) {

			if(allowdiag) {
				// 斜め移動あり
				var dx = (int)Mathf.Abs (xgoal - X);
				var dy = (int)Mathf.Abs (ygoal - Y);
				// 大きい方をコストにする
				_heuristic =  dx > dy ? dx : dy;
			}
			else {
				// 縦横移動のみ
				var dx = Mathf.Abs (xgoal - X);
				var dy = Mathf.Abs (ygoal - Y);
				_heuristic = (int)(dx + dy);
			}
			Dump();
		}
		/// ステータスがNoneかどうか.
		public bool IsNone() {
			return _status == eStatus.None;
		}
		/// ステータスをOpenにする.
		public void Open(ANode parent, int cost) {
			Debug.Log (string.Format("Open: ({0},{1})", X, Y));
			_status = eStatus.Open;
			_cost   = cost;
			_parent = parent;
		}
		/// ステータスをClosedにする.
		public void Close() {
			Debug.Log (string.Format ("Closed: ({0},{1})", X, Y));
			_status = eStatus.Closed;
		}
		/// パスを取得する
		public void GetPath(List<Point2> pList) {
			pList.Add(new Point2(X, Y));
			if(_parent != null) {
				_parent.GetPath(pList);
			}
		}
		public void Dump() {
			Debug.Log (string.Format("({0},{1})[{2}] cost={3} heuris={4} score={5}", X, Y, _status, _cost, _heuristic, GetScore()));
		}
		public void DumpRecursive() {
			Dump ();
			if(_parent != null) {
				// 再帰的にダンプする.
				_parent.DumpRecursive();
			}
		}
	}
}