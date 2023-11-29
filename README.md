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

##### 카메라 따라가기

카메라를 따라가는 방법은 Player에게 Main Camera를 주는 방식으로 구현했다.
그 외의 방법으로 시네머신을 이용하는 방법이 있다고 배웠으나, 시간 상의 문제로 적용하지 못했다.
 
</details>

#### 선택요구사항

<details>

##### 구현한 요구사항

#### 1. 캐릭터 애니메이션 추가 (난이도 - ★★☆☆☆)

캐릭터의 애니메이션은 유니티의 Animation 기능을 이용하여 만들었다.

#### 2. 이름 입력 시스템 (난이도 - ★★★☆☆)

게임 시작 시에 이름을 입력받도록 UI의 Input Field를 이용하였으며,
캐릭터의 이름을 지정하는 Text를 만든 뒤에 이를 Input Data로 변경하는 방식으로
캐릭터의 이름을 원하는대로 설정할 수 있게하였다.
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

#### 6. 인게임 이름 바꾸기 (난이도 - ★★★☆☆)

위의 아이디어를 이용하여 인게임 내에서도 이름을 바꿀 수 있게 하였다.
이름을 바꾸는 과정을 사진으로 보이면 아래와 같다.

<details>
	
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/464d7051-8c93-491e-aef0-25820c4e6a3f)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/1bcc572b-f7e4-4db4-b822-21054e246902)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/904aef21-2bdf-4e72-886a-99db9f74f526)
![image](https://github.com/Lawrence1031/Unity_Base_Assignment/assets/144416099/f6fcef88-db1f-4b72-9691-d1f5512f4c55)

</details>








3. 캐릭터 선택 시스템 (난이도 - ★★★★☆)
4. 참석 인원 UI (난이도 - ★★★☆☆)
5. 인게임 캐릭터 선택 (난이도 - ★★★★☆)
7. 시간 표시 (난이도 - ★★☆☆☆)
8. NPC 대화 (난이도 - ★★★★★)


 
</details>
