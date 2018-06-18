using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestMatch {

	[Test]
	public void TestPiece() {
		PieceController t = new PieceController ();
		t.Init (1, 1, new Match3Core.Grid (), Match3Core.PieceType.NORMAL);

		Assert.That (t.X == 1);
	}
}
