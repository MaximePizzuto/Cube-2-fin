import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LienpageaccueilComponent } from './lienpageaccueil.component';

describe('LienpageaccueilComponent', () => {
  let component: LienpageaccueilComponent;
  let fixture: ComponentFixture<LienpageaccueilComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LienpageaccueilComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LienpageaccueilComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
