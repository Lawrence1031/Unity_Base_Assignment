# Go Together Betelgeuse Forest
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/421b588f-6c7b-4ed6-8607-6c5ecb1ad84f)

## Chapter 3-1 Unity 과제

### 개발 환경 및 에셋 정보
<details>

#### 개발 환경
##### Unity 2022.3.2f1

#### 사용한 에셋
##### 탑다운 2D RPG 에셋 팩
https://assetstore.unity.com/packages/2d/characters/top-down-2d-rpg-assets-pack-188718

##### 2D Dungeon Pixel Art Tileset
https://assetstore.unity.com/packages/2d/environments/2d-dungeon-pixel-art-tileset-171343

##### PixelWitchery
https://assetstore.unity.com/packages/2d/pixelwitchery-239673

#### 사용한 폰트
##### 구글 Noto Sans Korean 폰트
##### https://fonts.google.com/noto/specimen/Noto+Sans+KR

#### 개발 기간
##### 4일 (20231124 ~ 20231129)
토, 일은 개인적인 사정으로 작업하지 못했음
</details>

### 게임 디자인과 관련하여

<details>

##### 이번 과제에서 구현하고자 하는 목표는 캐주얼한 2D 게임으로 힐링이 되는 게임을 만들어보자 가 메인이었다.
##### 따라서 아기자기한 디자인을 가진 캐릭터를 주인공으로 하려고 하다 좋은 에셋을 만나 그 에셋을 이용하여 작업하였다.
##### 게임을 만들면서 생각하였던 디자인은 '동물의 숲'으로 
##### 자유로운 환경에서 가벼운 디자인의 그래픽을 보며 힐링하는 것이 이번 게임이 추구하는 목표이다.


##### 게임의 기본 스토리는 평범하게 마을에 살고 있는 주인공이 옆집의 친구(angel)의 요청(퀘스트)으로
##### 숲에 가서 나무와 버섯을 구한다거나, 꽃을 가져온다거나 동물을 잡아오는 등의 간단한 작업을 하는 것으로,
##### 숲의 이름이 베텔기우스(Betelgeuse)로 몽환적인 느낌을 받을 수 있는 환경에서 생활한다는 스토리이다.
##### 게임은 주인공과 angel의 생활을 따라서 진행되며, 
##### 퀘스트를 진행할수록 호감도가 올라가 일정 수치가 넘어가면 특별한 이벤트를 볼 수 있고,
##### 엔딩은 주인공과 angel이 결혼해서 행복하게 사는 게임이다.


##### 이 게임은 특별한 전투는 없으며 캐릭터를 이동하면서 나오는 상호작용으로 채집하는 간단한 조작법을 갖고 있다.
##### 숲의 특정한 곳(지금 구현한 것으로는 하트나무숲)을 가면 그 곳의 사진이 저장되고 이후에 사진을 관람할 수 있다.
##### angel과의 이벤트나 demon과의 이벤트도 이후에 관람할 수 있는 사진으로 저장된다.

</details>


----

### 과제 세부 사항
<details>

#### 과제 개요
1. Unity 를 이용해 게더를 모방해 만드는 과제입니다.
2. 타일맵을 이용해 배경을 꾸밉니다.
3. 기본 UI 들을 활용해 적용하는 연습이 포함됩니다.

#### 요구사항
##### 필수요구사항
1. 캐릭터 만들기
	-  외부 그림파일을 추가하여 2D 캐릭터를 추가합니다.


2. 캐릭터 이동
	- 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다.
	- 캐릭터는 마우스 방향을 바라봅니다. (좌/우)


3. 방 만들기
	- 타일맵을 이용하여 맵을 만듭니다.
	- 콜라이더를 이용해 벽을 넘어가지 못합니다.


4. 카메라 따라가기
	- 카메라는 움직임에 따라 캐릭터를 따라갑니다.

	
##### 선택요구사항
1. 캐릭터 애니메이션 추가 (난이도 - ★★☆☆☆)
2. 이름 입력 시스템 (난이도 - ★★★☆☆)
3. 캐릭터 선택 시스템 (난이도 - ★★★★☆)
4. 참석 인원 UI (난이도 - ★★★☆☆)
5. 인게임 캐릭터 선택 (난이도 - ★★★★☆)
6. 인게임 이름 바꾸기 (난이도 - ★★★☆☆)
7. 시간 표시 (난이도 - ★★☆☆☆)
8. NPC 대화 (난이도 - ★★★★★)

</details>

----

### 실제로 구현한 기능 소개

#### 필수요구사항

<details>

##### 캐릭터 만들기

캐릭터는 PixelWitchery 의 에셋을 이용하여 만들었다.

##### 캐릭터 이동

캐릭터의 이동은 강의에서 배웠던 Player Input 을 통해서 만들었다.

##### 맵 만들기

맵은 탑다운 2D RPG 에셋 팩의 에셋을 이용하여 만들었다.
맵의 외곽이나 NPC, 건물이나 나무 등과는 충돌판정으로 통과하지 못하도록 구현하였다.

##### 카메라 따라가기

카메라를 따라가는 방법은 Player에게 Main Camera를 주는 방식으로 구현했다.
그 외의 방법으로 시네머신을 이용하는 방법이 있다고 배웠으나, 시간 상의 문제로 적용하지 못했다.
 
</details>

#### 추가로 구현한 기본사항

<details>

##### 1. 기본 UI만들기

게임의 플레이를 원활하게 하기 위해 기본 UI를 만들었으며, 이 UI를 이용하여

###### 좌측 상단에는 시간 표시를
###### 하단에는 대화에 필요한 공간을
###### 우측에는 메뉴를 만들어서 하려고 하는 동작을 할 수 있게

작업하였다. 
현재는 하단의 UnderUI가 항상 표시되지만, NPC와의 대화를 하는 경우에 표시되도록 할 예정이었다.
우측에는 선택요구사항에 있는 구현 내용들을 선택할 수 있는 메뉴 버튼을 만들었으나,
현재는 플레이어 이름 변경만이 가능하다.


 
</details>

#### 선택요구사항

<details>

#### 구현한 요구사항

##### 1. 캐릭터 애니메이션 추가 (난이도 - ★★☆☆☆)

캐릭터의 애니메이션은 유니티의 Animation 기능을 이용하여 만들었다.

##### 2. 이름 입력 시스템 (난이도 - ★★★☆☆)

Player의 이름을 지정하는 Text를 초기에 만들어 놓고 Player의 이름을 표시할 수 있도록 하였다.
게임 시작 시에 이름을 입력받도록 UI의 Input Field를 이용하였으며,
여기서 받은 데이터를 PlayerPrefs를 이용하여 이름을 저장한 뒤,
이를 가지고 Player의 이름을 Input Data로 변경하는 방식으로
Player의 이름을 원하는대로 설정할 수 있게하였다.
요구 사항에 있는 글자 수 제한도 설정하였다.
자세한 코드는 아래와 같다.

<details>

```
public TMP_InputField inputField;
public TextMeshProUGUI PlayerName;

// Start is called before the first frame update
void Start()
{
    GameObject playerObject = GameObject.Find("Player");

    if (playerObject != null)
    {
        Transform canvasTransform = playerObject.transform.Find("TextMeshProParent/Canvas");

        if (canvasTransform != null)
        {
            canvasTransform.gameObject.SetActive(true);
        }
    }

    inputField.onValueChanged.AddListener(PlayerNameInput);
}

void PlayerNameInput(string PName)
{
    PlayerName.text = PName;
}
```

</details>

##### 6. 인게임 이름 바꾸기 (난이도 - ★★★☆☆)

위의 아이디어를 이용하여 인게임 내에서도 이름을 바꿀 수 있게 하였다.
이름을 바꾸는 과정을 사진으로 보이면 아래와 같다.

<details>
	
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/464d7051-8c93-491e-aef0-25820c4e6a3f)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/1bcc572b-f7e4-4db4-b822-21054e246902)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/904aef21-2bdf-4e72-886a-99db9f74f526)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/f6fcef88-db1f-4b72-9691-d1f5512f4c55)

</details>

우측에 있는 '메뉴' 버튼을 누른 뒤에 그 곳에서 나타나는 '이름 변경' 버튼을 누르면
팝업 창으로 이름을 입력할 수 있는 창이 뜨고, 여기에 이름을 입력하면 Player의 이름을 변경할 수 있다.
이 부분에서도 똑같이 글자수 제한이 있어 그 제한범위 밖의 경우 '선택' 버튼이 눌리지 않게 하였다.

여기서 아직 구현하지 못한 것은
이름을 바꾸는 도중에 이동키(W, A, S, D)를 누르면 캐릭터가 이동하는 것으로
'이름 변경' 버튼을 누르는 경우에는 Player의 Movement 스크립트를 비활성화 시키고
'선택' 버튼을 누르면 다시 Player의 Movement 스크립트를 활성화 시키는 방법으로 구현하려고 하였으나
잘 되지 않았으며, 시간이 부족하여 우선은 이 부분은 미구현으로 진행하였다.


##### 7. 시간 표시 (난이도 - ★★☆☆☆)

##### 추가로 구현한 기본 UI의 좌측 상단에 항상 시간이 표시되도록 작업하였다.

</details>

#### 구현하지 못한 요구 사항

<details>

##### 3. 캐릭터 선택 시스템 (난이도 - ★★★★☆)

시작 부분에서 이름을 입력한 뒤에 캐릭터를 선택할 수 있도록 
캐릭터 선택 시스템을 도입하려고 하였으나, 캐릭터를 추가할 시간이 부족하여 작업하지 못했다.

##### 4. 참석 인원 UI (난이도 - ★★★☆☆)

참석 인원 UI의 경우, 기본 UI의 메뉴 버튼의 하위로 참가자를 볼 수 있는 버튼을 만들었으며,
이 버튼을 누르면 우측의 기본 UI의 메뉴 부분을 가리고 그 부분에 참가자들을 볼 수 있는 UI를 만들 예정이었다.

##### 5. 인게임 캐릭터 선택 (난이도 - ★★★★☆)

인게임 캐릭터의 선택의 경우, 캐릭터를 추가하였다면 같이 구현할 것으로 미뤘던 부분으로,
참석 인원 UI와 마찬가지로 우측에 존재하는 버튼으로 해당 기능에 접근할 수 있으며,
'캐릭터 선택' 버튼을 누르면 '이름 변경'과 같은 방식으로 
중앙에 팝업창이 뜨며 그 팝업창에서 캐릭터를 선택할 수 있도록 할 예정이었다.

캐릭터의 변경의 경우, C# 스크립트를 통해 현재 캐릭터의 이미지와 애니메이션을 찾은 뒤에
Player가 선택한 정보의 캐릭터의 이미지와 애니메이션을 그 곳에 집어넣는 방식으로 진행할 예정이었다.

##### 8. NPC 대화 (난이도 - ★★★★★)

NPC와 대화의 경우. 이전에 공부했었던 레이캐스트를 사용하지 않고
2D라는 개념을 살려서 NPC의 위치 주변으로 조금 더 큰 범위의 Box Collider를 만든 뒤에
Player가 이 범위에 들어오는 경우 (OnTriggerEnter2D)를 통해서 확인하여
Player인 경우 NPC의 주변에 상호작용 키가 나타나며 활성화되게 한 뒤,
그 상태에서 상화작용 키를 누른다면 UnderUI가 나타나며 대화를 하는 방식으로 구현하려고 했었다.

이 아이디어를 이용하여 02_MainScene에서 03_Stage1Scene으로 이동하는 Scene 이동을 구현하였다.
 
</details>


#### 추가로 구현한 사항

<details>

게임의 디자인을 숲을 둘러보는 식으로 디자인했기 때문에 Scene을 나눈 뒤에 Scene의 이동을 구현하려고 했는데,

NPC와의 대화를 진행하는 방식에서 아이디어를 얻어서 특정 위치에 Player가 이동하면 다음 Scene으로 이동하는 방식으로 구현하였다.




 
</details>





















	
