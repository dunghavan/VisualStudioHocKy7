#include"BackGround.h"

BackGround::BackGround(int x, int y) :Object(x, y){
	Texture = new GTexture("dota_map.jpg", 1, 1, 1);
	Sprite = new GSprite(Texture, 120);
};
void BackGround::Draw()
{
	D3DXVECTOR2 pos = Camera.Transform(x, y);
	Sprite->Draw(pos.x,pos.y);
}